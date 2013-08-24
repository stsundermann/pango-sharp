namespace Pango {

	using System;
	using System.Runtime.InteropServices;

	public partial class Layout {

		[DllImport ("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_get_log_attrs (IntPtr raw, out IntPtr attrs, out int n_attrs);

		public LogAttr [] LogAttrs {
			get {
				int count;
				IntPtr array_ptr;
				pango_layout_get_log_attrs (Handle, out array_ptr, out count);
				if (array_ptr == IntPtr.Zero)
					return new LogAttr [0];
				LogAttr [] result = new LogAttr [count];
				for (int i = 0; i < count; i++) {
					IntPtr fam_ptr = Marshal.ReadIntPtr (array_ptr, i * IntPtr.Size);
					result [i] = LogAttr.New (fam_ptr);
				}

				GLib.Marshaller.Free (array_ptr);
				return result;
			}
		}
	}
}