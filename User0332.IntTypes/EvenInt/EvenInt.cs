using System.Numerics;

namespace User0332.IntTypes;

/// <summary>
/// Represents a 32-bit signed even integer
/// </summary>
public readonly struct EvenInt : IConvertible, IComparable<EvenInt>
{
	internal readonly uint val = 0;

	public readonly bool IsNegative {
		get => (val & 1) == 1;
	}

	public EvenInt(uint val)
	{
		if (val % 2 != 0) throw new OverflowException();

		this.val |= val;

		if (val < 0) this.val |= 1; // negative masking
	}

	public EvenInt(StackEvenInt evenInt)
	{
		val = evenInt.val;
	}

	public static EvenInt ConvertFromEvenInt(StackEvenInt evenInt)
	{
		return new(evenInt);
	}

	// public static EvenInt operator +(EvenInt self, EvenInt other)
	// {
	// 	return new EvenInt();
	// }
	public readonly Integral ConvertTo<Integral>() where Integral : struct, IBinaryInteger<Integral>
	{
		return ConvertTo<Integral>(this);
	}

	public static Integral ConvertTo<Integral>(EvenInt num) where Integral : struct, IBinaryInteger<Integral>
	{
		if (num.IsNegative)
		{
			uint uintVal = num.val-1;

			return (Integral) Convert.ChangeType(-uintVal, typeof(Integral));
		}

		return (Integral) Convert.ChangeType(num.val, typeof(Integral));
	}

	public readonly int CompareTo(EvenInt other)
	{
		return ToInt64().CompareTo(other.ToInt64()); // optimize this later
	}

	public readonly StackEvenInt ToStackEvenInt()
	{
		return new(val);
	}

	public readonly long ToInt64(IFormatProvider? provider = null)
	{
		if (IsNegative)
		{
			uint uintVal = val-1;

			return -uintVal;
		}

		return val;
	}

	public readonly ulong ToUInt64(IFormatProvider? provider = null)
	{
		return (ulong) ToInt64(provider);
	}

	public readonly int ToInt32(IFormatProvider? provider = null)
	{
		return (int) ToInt64(provider);
	}

	public readonly uint ToUInt32(IFormatProvider? provider = null)
	{
		return (uint) ToInt64(provider);
	}

	public readonly short ToInt16(IFormatProvider? provider = null)
	{
		return (short) ToInt64(provider);
	}

	public readonly ushort ToUInt16(IFormatProvider? provider = null)
	{
		return (ushort) ToInt64(provider);
	}

	public readonly byte ToByte(IFormatProvider? provider = null)
	{
		return (byte) ToInt64(provider);
	}

	public readonly sbyte ToSByte(IFormatProvider? provider = null)
	{
		return (sbyte) ToInt64(provider);
	}

	public readonly string ToString(IFormatProvider? provider)
	{
		return ToInt64(provider).ToString();
	}

	public override readonly string ToString()
	{
		return ToString(null);
	}

	public readonly object ToType(Type type, IFormatProvider? provider = null)
	{
		throw new InvalidCastException();
	}

	public readonly TypeCode GetTypeCode()
	{
		return TypeCode.Object;
	}

	public readonly float ToSingle(IFormatProvider? provider = null)
	{
		return ToInt64(provider);
	}

	public readonly double ToDouble(IFormatProvider? provider = null)
	{
		return ToInt64(provider);
	}

	public readonly decimal ToDecimal(IFormatProvider? provider = null)
	{
		return ToInt64(provider);
	}

	public readonly bool ToBoolean(IFormatProvider? provider = null)
	{
		return val != 0;
	}

	public readonly char ToChar(IFormatProvider? provider = null)
	{
		throw new InvalidCastException();
	}

	public readonly DateTime ToDateTime(IFormatProvider? provider = null)
	{
		throw new InvalidCastException();
	}
	
}

/// <summary>
/// Represents a 32-bit signed even integer stored on the stack
/// </summary>
public readonly ref struct StackEvenInt
{
	internal readonly uint val = 0;

	public readonly bool IsNegative {
		get => (val & 1) == 1;
	}

	public StackEvenInt(uint val)
	{
		if (val % 2 != 0) throw new OverflowException();

		this.val |= val;

		if (val < 0) this.val |= 1; // negative masking
	}

	public StackEvenInt(EvenInt evenInt)
	{
		val = evenInt.val;
	}

	public static StackEvenInt ConvertFromEvenInt(EvenInt evenInt)
	{
		return new(evenInt);
	}

	// public static EvenInt operator +(EvenInt self, EvenInt other)
	// {
	// 	return new EvenInt();
	// }
	public readonly Integral ConvertTo<Integral>() where Integral : struct, IBinaryInteger<Integral>
	{
		return ConvertTo<Integral>(this);
	}

	public static Integral ConvertTo<Integral>(StackEvenInt num) where Integral : struct, IBinaryInteger<Integral>
	{
		if (num.IsNegative)
		{
			uint uintVal = num.val-1;

			return (Integral) Convert.ChangeType(-uintVal, typeof(Integral));
		}

		return (Integral) Convert.ChangeType(num.val, typeof(Integral));
	}

	public readonly EvenInt ToEvenInt()
	{
		return new(val);
	}

	public readonly int CompareTo(EvenInt other)
	{
		return ToInt64().CompareTo(other.ToInt64()); // optimize this later
	}

	public readonly long ToInt64(IFormatProvider? provider = null)
	{
		if (IsNegative)
		{
			uint uintVal = val-1;

			return -uintVal;
		}

		return val;
	}

	public readonly ulong ToUInt64(IFormatProvider? provider = null)
	{
		return (ulong) ToInt64(provider);
	}

	public readonly int ToInt32(IFormatProvider? provider = null)
	{
		return (int) ToInt64(provider);
	}

	public readonly uint ToUInt32(IFormatProvider? provider = null)
	{
		return (uint) ToInt64(provider);
	}

	public readonly short ToInt16(IFormatProvider? provider = null)
	{
		return (short) ToInt64(provider);
	}

	public readonly ushort ToUInt16(IFormatProvider? provider = null)
	{
		return (ushort) ToInt64(provider);
	}

	public readonly byte ToByte(IFormatProvider? provider = null)
	{
		return (byte) ToInt64(provider);
	}

	public readonly sbyte ToSByte(IFormatProvider? provider = null)
	{
		return (sbyte) ToInt64(provider);
	}

	public readonly string ToString(IFormatProvider? provider)
	{
		return ToInt64(provider).ToString();
	}

	public override readonly string ToString()
	{
		return ToString(null);
	}

	public readonly object ToType(Type type, IFormatProvider? provider = null)
	{
		throw new InvalidCastException();
	}

	public readonly TypeCode GetTypeCode()
	{
		return TypeCode.Object;
	}

	public readonly float ToSingle(IFormatProvider? provider = null)
	{
		return ToInt64(provider);
	}

	public readonly double ToDouble(IFormatProvider? provider = null)
	{
		return ToInt64(provider);
	}

	public readonly decimal ToDecimal(IFormatProvider? provider = null)
	{
		return ToInt64(provider);
	}

	public readonly bool ToBoolean(IFormatProvider? provider = null)
	{
		return val != 0;
	}

	public readonly char ToChar(IFormatProvider? provider = null)
	{
		throw new InvalidCastException();
	}

	public readonly DateTime ToDateTime(IFormatProvider? provider = null)
	{
		throw new InvalidCastException();
	}
	
}