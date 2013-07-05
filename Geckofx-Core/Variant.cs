using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko
{
	public class Variant
	{
		private nsIVariant _variant;

		internal Variant() {}

		private Variant( nsIVariant variant )
		{
			_variant = variant;
			
		}

		public object Value
		{
			get { return GetValue(); }
		}


		public static Variant Create(nsIVariant variant)
		{
			var writable = Xpcom.QueryInterface<nsIWritableVariant>( variant );
			return writable != null ? new WritableVariant( writable ) : new Variant( variant );
		}


		protected object GetValue()
		{
			switch ((DataType)_variant.GetDataTypeAttribute())
			{
				case DataType.Int8:
					return _variant.GetAsInt8();
				case DataType.Int16:
					return _variant.GetAsInt16();
				case DataType.Int32:
					return _variant.GetAsInt32();
				case DataType.Int64:
					return _variant.GetAsInt64();
				default:
					return null;
			}
		}

		public sbyte GetAsInt8()
		{
			return (sbyte)_variant.GetAsInt8();
		}
	}

	


	public sealed class WritableVariant
		: Variant
	{
		private InstanceWrapper<nsIWritableVariant> _writableVariant;

		/// <summary>
		/// Creates new writable Variant
		/// </summary>
		public WritableVariant()
		{
			_writableVariant = new InstanceWrapper<nsIWritableVariant>( Contracts.WritableVariant );
		}
		
		internal WritableVariant(nsIWritableVariant writableVariant)
		{
			_writableVariant = new InstanceWrapper<nsIWritableVariant>( writableVariant );
		}

		public bool Writable
		{
			get { return _writableVariant.Instance.GetWritableAttribute(); }
			set { _writableVariant.Instance.SetWritableAttribute( value ); }
		}

		public void SetString( string value )
		{
			_writableVariant.Instance.SetAsWString( value );
		}
	}


	public enum DataType
		:ushort
	{
		Int8=0,
		Int16=1,
		Int32=2,
		Int64=3,
		UInt8=4,
		UInt16=5,
		UInt32=6,
		UInt64=7,
		Float=8,
		Double=9,
		Bool=10,
		Char=11,
		Wchar=12,
		Void=13,
		ID=14,
		DomString=15,
		CharPtr=16,
		WCharPtr=17,
		Interface=18,
		InterfaceIs=19,
		Array=20,
		StringSizeIs=21,
		WStringSizeIs=22,
		Utf8String=23,
		CString=24,
		AString=25,
		EmptyArray=254,
		Empty=255
	}
}
