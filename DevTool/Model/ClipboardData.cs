using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTool.Model
{
    /// <summary>
    /// Holds clipboard data of a single data format.
    /// </summary>
    [Serializable]
    class ClipboardData
    {
        public ClipboardData() { }
        /// <summary>
        /// Init a Clip Data object, containing one clipboard data and its format
        /// </summary>
        /// <param name="format"></param>
        /// <param name="formatName"></param>
        /// <param name="buffer"></param>
        public ClipboardData(uint format, string formatName, byte[] buffer)
        {
            this._format = format;
            this._formatName = formatName;
            this._buffer = buffer;
            this._size = 0;
        }

        private uint _format;

        /// <summary>
        /// Get or Set the format code of the data 
        /// </summary>
        public uint Format
        {
            get => _format;
            set => _format = value;
        }

        private string _formatName;
        /// <summary>
        /// Get or Set the format name of the data 
        /// </summary>
        public string FormatName
        {
            get => _formatName;
            set => _formatName = value;
        }

        private byte[] _buffer;
        /// <summary>
        /// Get or Set the buffer data
        /// </summary>
        public byte[] Buffer
        {
            get => _buffer;
            set => _buffer = value;
        }

        private readonly int _size;
        /// <summary>
        /// Get the data buffer lenght
        /// </summary>
        public UIntPtr Size
        {
            get
            {
                if (_buffer != null)
                {
                    //Read the correct size from buffer, if it is not null
                    return new UIntPtr(Convert.ToUInt32(_buffer.GetLength(0)));
                }
                else
                {
                    //else return the optional set size
                    return new UIntPtr(Convert.ToUInt32(_size));
                }
            }
        }
      
    }
}
