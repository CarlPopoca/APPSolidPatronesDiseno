using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.Prototype
{
	class UploadedFile : IUploadedFile
	{
		public string FileName { get; set ; }
		public long size { get ; set ; }
		public string ContentType { get ; set ; }
		public DateTime TimeStamp { get ; set ; }
		public byte[] FileContent { get ; set ; }

		public IUploadedFile Clone()
		{
			return (IUploadedFile)this.MemberwiseClone();
		}
	}
}
