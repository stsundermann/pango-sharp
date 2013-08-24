namespace Pango {

	using System;
	using System.Runtime.InteropServices;

	public partial class FontFace {

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_font_face_list_sizes(IntPtr raw, out IntPtr sizes, out int n_sizes);

		public int[] ListSizes() {
			int length;
			IntPtr ptr;
			pango_font_face_list_sizes(Handle, out ptr, out length);
			int[] sizes = new int[length];
			Marshal.Copy (ptr, sizes, 0, length);
			GLib.Marshaller.Free (ptr);
			return sizes;
		}
	}
}
