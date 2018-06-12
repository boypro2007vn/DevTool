using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DevTool.Model;
using DevTool.Services;

namespace DevTool.Common
{
    class ClipboardHelper
    {
        /// <summary>
        /// Convert to a DataClip collection all data present in the clipboard
        /// </summary>
        /// <returns></returns>
        public static ReadOnlyCollection<ClipboardData> GetClipboard()
        {
            //Init a list of ClipData, which will contain each Clipboard Data
            List<ClipboardData> clipData = new List<ClipboardData>();

            //Open Clipboard to allow us to read from it
            if (!ClipboardApi.OpenClipboard(IntPtr.Zero))
                return new ReadOnlyCollection<ClipboardData>(clipData);

            //Loop for each clipboard data type
            uint format = 0;
            while ((format = ClipboardApi.EnumClipboardFormats(format)) != 0)
            {
                //Check if clipboard data type is recognized, and get its name
                string formatName = "0";
                if (format > 14)
                {
                    StringBuilder res = new StringBuilder();
                    if (ClipboardApi.GetClipboardFormatName(format, res, 100) > 0)
                    {
                        formatName = res.ToString();
                    }

                }
                //Get the pointer for the current Clipboard Data 
                IntPtr pos = ClipboardApi.GetClipboardData(format);
                //Goto next if it's unreachable
                if (pos == IntPtr.Zero)
                    continue;
                //Get the clipboard buffer data properties
                UIntPtr lenght = MemoryApi.GlobalSize(pos);
                IntPtr gLock = MemoryApi.GlobalLock(pos);
                byte[] buffer;
                if ((int)lenght > 0)
                {
                    //Init a buffer which will contain the clipboard data
                    buffer = new byte[(int)lenght];
                    int l = Convert.ToInt32(lenght.ToString());
                    //Copy data from clipboard to our byte[] buffer
                    Marshal.Copy(gLock, buffer, 0, l);
                }
                else
                {
                    buffer = new byte[0];
                }
                //Create a ClipData object that represtens current clipboard data
                var cd = new ClipboardData(format, formatName, buffer);
                cd.FormatName = formatName;
                //Add current Clipboard Data to the list


                clipData.Add(cd);
            }
            //Close the clipboard and realese unused resources
            ClipboardApi.CloseClipboard();
            //Returns the list of Clipboard Datas as a ReadOnlyCollection of ClipData
            return new ReadOnlyCollection<ClipboardData>(clipData);
        }

        /// <summary>
        /// Empty the Clipboard and Restore to system clipboard data contained in a collection of ClipData objects
        /// </summary>
        /// <param name="clipData">The collection of ClipData containing data stored from clipboard</param>
        /// <returns></returns>    
        public static bool SetClipboard(ReadOnlyCollection<ClipboardData> clipData)
        {
            //Open clipboard to allow its manipultaion
            if (!ClipboardApi.OpenClipboard(IntPtr.Zero))
                return false;

            //Clear the clipboard
            EmptyClipboard();

            //Get an Enumerator to iterate into each ClipData contained into the collection
            IEnumerator<ClipboardData> cData = clipData.GetEnumerator();
            while (cData.MoveNext())
            {
                ClipboardData cd = cData.Current;

                //Get the pointer for inserting the buffer data into the clipboard
                IntPtr alloc = MemoryApi.GlobalAlloc(MemoryApi.GMEM_MOVEABLE | MemoryApi.GMEM_DDESHARE, cd.Size);
                IntPtr gLock = MemoryApi.GlobalLock(alloc);

                //Clopy the buffer of the ClipData into the clipboard
                if ((int)cd.Size > 0)
                {
                    Marshal.Copy(cd.Buffer, 0, gLock, cd.Buffer.GetLength(0));
                }
                else
                {
                }
                //Release pointers 
                MemoryApi.GlobalUnlock(alloc);
                ClipboardApi.SetClipboardData(cd.Format, alloc);
            };
            //Close the clipboard to realese unused resources
            ClipboardApi.CloseClipboard();
            return true;
        }

        public static bool EmptyClipboard()
        {
            return ClipboardApi.EmptyClipboard();
        }
    }
}
