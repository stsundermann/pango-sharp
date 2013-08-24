namespace Pango {

	using System;
	using System.Runtime.InteropServices;

	public partial class FontFamily {

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_font_family_list_faces(IntPtr raw, out IntPtr faces, out int n_faces);

		public Pango.FontFace[] Faces {
			get {
				IntPtr ptr;
				int length;

				pango_font_family_list_faces (Handle, out ptr, out length);

				Pango.FontFace[] faces = new Pango.FontFace[length];

				for (int i = 0; i < length; i++) {
					faces [i] = new FontFace (Marshal.ReadIntPtr (ptr));
					ptr = (IntPtr)((long)ptr + Marshal.SizeOf (typeof(IntPtr)));
				}

				return faces;
			}
		}
	}
}