
namespace SylphyHorn.Interop
{
	public static class Platform
	{
		public static bool IsUwp
#if APPX
			=> false;
#else
			=> false;
#endif
	}
}
