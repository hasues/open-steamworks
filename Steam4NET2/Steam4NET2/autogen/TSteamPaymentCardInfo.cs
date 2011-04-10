// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct TSteamPaymentCardInfo
	{
		ESteamPaymentCardType eCardType;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 18)]
		string szCardNumber;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		string szCardHolderName;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
		string szCardExpYear;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
		string szCardExpMonth;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
		string szCardCVV2;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		string szBillingAddress1;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		string szBillingAddress2;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		string szBillingCity;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		string szBillingZip;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		string szBillingState;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		string szBillingCountry;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		string szBillingPhone;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		string szBillingEmailAddress;
		UInt32 uExpectedCostInCents;
		UInt32 uExpectedTaxInCents;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		string szShippingName;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		string szShippingAddress1;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
		string szShippingAddress2;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 51)]
		string szShippingCity;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 17)]
		string szShippingZip;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		string szShippingState;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
		string szShippingCountry;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 21)]
		string szShippingPhone;
		UInt32 uExpectedShippingCostInCents;
	};
	
}