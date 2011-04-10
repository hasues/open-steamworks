// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamBilling001VTable
	{
		public IntPtr SetBillingAddress0;
		public IntPtr GetBillingAddress1;
		public IntPtr SetShippingAddress2;
		public IntPtr GetShippingAddress3;
		public IntPtr GetFinalPrice4;
		public IntPtr SetCardInfo5;
		public IntPtr GetCardInfo6;
		public IntPtr Purchase7;
		private IntPtr DTorISteamBilling0018;
	};
	
	public class ISteamBilling001 : InteropHelp.NativeWrapper<ISteamBilling001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetBillingAddressSSSSSSSS( IntPtr thisptr, string pchName, string pchAddress1, string pchAddress2, string pchCity, string pchPostcode, string pchState, string pchCountry, string pchPhone );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetBillingAddress( string pchName, string pchAddress1, string pchAddress2, string pchCity, string pchPostcode, string pchState, string pchCountry, string pchPhone ) 
		{
			return this.GetFunction<NativeSetBillingAddressSSSSSSSS>( this.Functions.SetBillingAddress0 )( this.ObjectAddress, pchName, pchAddress1, pchAddress2, pchCity, pchPostcode, pchState, pchCountry, pchPhone ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetBillingAddressSSSSSSSS( IntPtr thisptr, StringBuilder pchName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetBillingAddress( StringBuilder pchName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone ) 
		{
			return this.GetFunction<NativeGetBillingAddressSSSSSSSS>( this.Functions.GetBillingAddress1 )( this.ObjectAddress, pchName, pchAddress1, pchAddress2, pchCity, pchPostcode, pchState, pchCountry, pchPhone ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetShippingAddressSSSSSSSS( IntPtr thisptr, string pchName, string pchAddress1, string pchAddress2, string pchCity, string pchPostcode, string pchState, string pchCountry, string pchPhone );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetShippingAddress( string pchName, string pchAddress1, string pchAddress2, string pchCity, string pchPostcode, string pchState, string pchCountry, string pchPhone ) 
		{
			return this.GetFunction<NativeSetShippingAddressSSSSSSSS>( this.Functions.SetShippingAddress2 )( this.ObjectAddress, pchName, pchAddress1, pchAddress2, pchCity, pchPostcode, pchState, pchCountry, pchPhone ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetShippingAddressSSSSSSSS( IntPtr thisptr, StringBuilder pchName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetShippingAddress( StringBuilder pchName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone ) 
		{
			return this.GetFunction<NativeGetShippingAddressSSSSSSSS>( this.Functions.GetShippingAddress3 )( this.ObjectAddress, pchName, pchAddress1, pchAddress2, pchCity, pchPostcode, pchState, pchCountry, pchPhone ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFinalPriceI( IntPtr thisptr, Int32 nPackageID );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetFinalPrice( Int32 nPackageID ) 
		{
			return this.GetFunction<NativeGetFinalPriceI>( this.Functions.GetFinalPrice4 )( this.ObjectAddress, nPackageID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetCardInfoESSSSS( IntPtr thisptr, ECreditCardType eCreditCardType, string pchCardNumber, string pchCardHolderName, string pchCardExpYear, string pchCardExpMonth, string pchCardCVV2 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool SetCardInfo( ECreditCardType eCreditCardType, string pchCardNumber, string pchCardHolderName, string pchCardExpYear, string pchCardExpMonth, string pchCardCVV2 ) 
		{
			return this.GetFunction<NativeSetCardInfoESSSSS>( this.Functions.SetCardInfo5 )( this.ObjectAddress, eCreditCardType, pchCardNumber, pchCardHolderName, pchCardExpYear, pchCardExpMonth, pchCardCVV2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetCardInfoESSSSS( IntPtr thisptr, ref ECreditCardType eCreditCardType, StringBuilder pchCardNumber, StringBuilder pchCardHolderName, StringBuilder pchCardExpYear, StringBuilder pchCardExpMonth, StringBuilder pchCardCVV2 );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool GetCardInfo( ref ECreditCardType eCreditCardType, StringBuilder pchCardNumber, StringBuilder pchCardHolderName, StringBuilder pchCardExpYear, StringBuilder pchCardExpMonth, StringBuilder pchCardCVV2 ) 
		{
			return this.GetFunction<NativeGetCardInfoESSSSS>( this.Functions.GetCardInfo6 )( this.ObjectAddress, ref eCreditCardType, pchCardNumber, pchCardHolderName, pchCardExpYear, pchCardExpMonth, pchCardCVV2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativePurchaseIIUB( IntPtr thisptr, Int32 nPackageID, Int32 nExpectedCostCents, UInt64 gidCardID, [MarshalAs(UnmanagedType.I1)] bool bStoreCardInfo );
		[return: MarshalAs(UnmanagedType.I1)]
		public bool Purchase( Int32 nPackageID, Int32 nExpectedCostCents, UInt64 gidCardID, bool bStoreCardInfo ) 
		{
			return this.GetFunction<NativePurchaseIIUB>( this.Functions.Purchase7 )( this.ObjectAddress, nPackageID, nExpectedCostCents, gidCardID, bStoreCardInfo ); 
		}
		
	};
}