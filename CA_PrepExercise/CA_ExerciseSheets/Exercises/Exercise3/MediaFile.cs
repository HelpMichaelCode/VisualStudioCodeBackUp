using System;
namespace Exercise3
{
    public class MediaFile
    {
        private string _fileName;
        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                if(_fileName == String.Empty)
                {
                    throw new ArgumentException("Empty file name!");
                }
                else
                {
                    _fileName = value;
                }
            }
        }

        public MediaFile(string fileName)
        {
            this._fileName = fileName;
        }

        public override string ToString()
        {
            return $"Filename: {FileName}";
        }

    }
}
