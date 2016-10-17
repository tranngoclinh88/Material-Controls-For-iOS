using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using ObjCRuntime;

namespace MaterialControls
{
	[Native]
	public enum MDCalendarMonthSymbolsFormat : nint
	{
		Short = 0,
		Full = 1,
		ShortUppercase = 2,
		FullUppercase = 3
	}

	[Native]
	public enum MDCalendarCellStyle : nint
	{
		Circle = 0,
		Rectangle = 1
	}

	[Native]
	public enum MDCalendarCellState : nint
	{
		Normal = 0,
		Selected = 1,
		Placeholder = 1 << 1,
		Disabled = 1 << 2,
		Today = 1 << 3,
		Weekend = 1 << 4,
		WeekTitle = 1 << 5,
		MonthTitle = 1 << 6,
		Button = 1 << 7
	}

	[Native]
	public enum MDCalendarTheme : nint
	{
		Light = 1,
		Dark = 2
	}

	[Native]
	public enum MDClockMode : nint
	{
		MDClockMode12H,
		MDClockMode24H
	}

	[Native]
	public enum MDTimePickerTheme : nint
	{
		Light = 1,
		Dark
	}

	[Native]
	public enum MDFontFamilySize : nint
	{
		Regular = 0,
		Bold = 1,
		Light = 2,
		Medium = 3,
		Thin = 4,
		Black = 5
	}

	[Native]
	public enum MDFontFamilyType : nint
	{
		Bold = 1,
		Italic = 2
	}

	static class CFunctions
	{
		// CGPoint CGRectCenter (CGRect rect) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern CGPoint CGRectCenter (CGRect rect);

		// CGPoint CGRectCenter (CGRect rect) __attribute__((cf_audited_transfer));
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern CGPoint CGRectCenter (CGRect rect);
	}

	[Native]
	public enum MDButtonType : nint
	{
		Raised,
		Flat,
		FloatingAction,
		FloatingActionRotation
	}

	[Native]
	public enum MDProgressStyle : nint
	{
		Circular,
		Linear
	}

	[Native]
	public enum MDProgressType : nint
	{
		Indeterminate,
		Determinate
	}

	[Native]
	public enum MDTextFieldViewState : nint
	{
		Normal,
		Highlighted,
		Error,
		Disabled
	}

	[Native]
	public enum MDGravity : nint
	{
		None = 0,
		Top = 1 << 0,
		Bottom = 1 << 1,
		Left = 1 << 2,
		Right = 1 << 3,
		CenterHorizontal = 1 << 4,
		CenterVertical = 1 << 5
	}
}
