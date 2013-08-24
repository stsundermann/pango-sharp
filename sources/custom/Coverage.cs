namespace Pango {

	using System;
	using System.Runtime.InteropServices;

	public partial class Coverage {
		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_coverage_to_bytes(IntPtr raw, out IntPtr bytes, out int n_bytes);

		public byte[] ToBytes() {
			IntPtr ptr;
			int length;

			pango_coverage_to_bytes(Handle, out ptr, out length);
			byte[] bytes = new byte[length];	
			Marshal.Copy (ptr, bytes, 0, length);
			GLib.Marshaller.Free (ptr);
			return bytes;
		}
	}
}