using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmSolidPatronesDiseño.PatronesDiseño.Prototype
{
	interface IUploadedFile
	{
		string FileName { get; set; }
		long size { get; set; }
		string ContentType { get; set; }
		DateTime TimeStamp { get; set; }
		byte[] FileContent { get; set; }
		IUploadedFile Clone();
	}
}
