﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using ZeroLog.Utils;

namespace ZeroLog
{
    partial interface ILogEvent
    {
        ILogEvent Append(bool value);
        ILogEvent Append(bool? value);
        ILogEvent Append(byte value);
        ILogEvent Append(byte? value);
        ILogEvent Append(byte value, string format);
        ILogEvent Append(byte? value, string format);
        ILogEvent Append(char value);
        ILogEvent Append(char? value);
        ILogEvent Append(short value);
        ILogEvent Append(short? value);
        ILogEvent Append(short value, string format);
        ILogEvent Append(short? value, string format);
        ILogEvent Append(int value);
        ILogEvent Append(int? value);
        ILogEvent Append(int value, string format);
        ILogEvent Append(int? value, string format);
        ILogEvent Append(long value);
        ILogEvent Append(long? value);
        ILogEvent Append(long value, string format);
        ILogEvent Append(long? value, string format);
        ILogEvent Append(float value);
        ILogEvent Append(float? value);
        ILogEvent Append(float value, string format);
        ILogEvent Append(float? value, string format);
        ILogEvent Append(double value);
        ILogEvent Append(double? value);
        ILogEvent Append(double value, string format);
        ILogEvent Append(double? value, string format);
        ILogEvent Append(decimal value);
        ILogEvent Append(decimal? value);
        ILogEvent Append(decimal value, string format);
        ILogEvent Append(decimal? value, string format);
        ILogEvent Append(Guid value);
        ILogEvent Append(Guid? value);
        ILogEvent Append(Guid value, string format);
        ILogEvent Append(Guid? value, string format);
        ILogEvent Append(DateTime value);
        ILogEvent Append(DateTime? value);
        ILogEvent Append(DateTime value, string format);
        ILogEvent Append(DateTime? value, string format);
        ILogEvent Append(TimeSpan value);
        ILogEvent Append(TimeSpan? value);
        ILogEvent Append(TimeSpan value, string format);
        ILogEvent Append(TimeSpan? value, string format);
    }

    unsafe partial class LogEvent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AppendGeneric<T>(T arg)
        {
            // Some remarks here:
            // - The JIT knows the type of "arg" at runtime and will be able the remove useless branches for each
            //   struct specific jitted version of this method.
            // - Since a jitted version of this method will be shared for all reference types, the optimisation
            //   we just mentionned earlier can't occur. That's why we put the test against string at the top.
            // - Casting to "object" then to the desired value type will force the C# compiler to emit boxing and 
            //   unboxing IL opcodes, but the JIT is smart enough to prevent the actual boxing/unboxing from happening.

            if (typeof(T) == typeof(string))
                Append((string)(object)arg);
            else if (typeof(T) == typeof(bool))
                Append((bool)(object)arg);
            else if (typeof(T) == typeof(bool?))
                Append((bool?)(object)arg);
            else if (typeof(T) == typeof(byte))
                Append((byte)(object)arg);
            else if (typeof(T) == typeof(byte?))
                Append((byte?)(object)arg);
            else if (typeof(T) == typeof(char))
                Append((char)(object)arg);
            else if (typeof(T) == typeof(char?))
                Append((char?)(object)arg);
            else if (typeof(T) == typeof(short))
                Append((short)(object)arg);
            else if (typeof(T) == typeof(short?))
                Append((short?)(object)arg);
            else if (typeof(T) == typeof(int))
                Append((int)(object)arg);
            else if (typeof(T) == typeof(int?))
                Append((int?)(object)arg);
            else if (typeof(T) == typeof(long))
                Append((long)(object)arg);
            else if (typeof(T) == typeof(long?))
                Append((long?)(object)arg);
            else if (typeof(T) == typeof(float))
                Append((float)(object)arg);
            else if (typeof(T) == typeof(float?))
                Append((float?)(object)arg);
            else if (typeof(T) == typeof(double))
                Append((double)(object)arg);
            else if (typeof(T) == typeof(double?))
                Append((double?)(object)arg);
            else if (typeof(T) == typeof(decimal))
                Append((decimal)(object)arg);
            else if (typeof(T) == typeof(decimal?))
                Append((decimal?)(object)arg);
            else if (typeof(T) == typeof(Guid))
                Append((Guid)(object)arg);
            else if (typeof(T) == typeof(Guid?))
                Append((Guid?)(object)arg);
            else if (typeof(T) == typeof(DateTime))
                Append((DateTime)(object)arg);
            else if (typeof(T) == typeof(DateTime?))
                Append((DateTime?)(object)arg);
            else if (typeof(T) == typeof(TimeSpan))
                Append((TimeSpan)(object)arg);
            else if (typeof(T) == typeof(TimeSpan?))
                Append((TimeSpan?)(object)arg);
            else if (TypeUtil<T>.IsEnum)
                AppendEnumInternal(arg);
            else
                AppendGenericSlow(arg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(bool value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(bool)))
                return this;

            AppendArgumentType(ArgumentType.Boolean);
            *(bool*)_dataPointer = value;
            _dataPointer += sizeof(bool);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(bool? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(bool)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Boolean);
            *(bool*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(bool);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(byte value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte)))
                return this;

            AppendArgumentType(ArgumentType.Byte);
            *(byte*)_dataPointer = value;
            _dataPointer += sizeof(byte);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(byte? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Byte);
            *(byte*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(byte);
            return this;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(byte value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(byte)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.Byte);
            AppendString(format);
            *(byte*)_dataPointer = value;
            _dataPointer += sizeof(byte);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(byte? value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(byte)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.Byte);
            AppendString(format);
            *(byte*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(byte);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(char value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(char)))
                return this;

            AppendArgumentType(ArgumentType.Char);
            *(char*)_dataPointer = value;
            _dataPointer += sizeof(char);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(char? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(char)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Char);
            *(char*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(char);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(short value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(short)))
                return this;

            AppendArgumentType(ArgumentType.Int16);
            *(short*)_dataPointer = value;
            _dataPointer += sizeof(short);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(short? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(short)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Int16);
            *(short*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(short);
            return this;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(short value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(short)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.Int16);
            AppendString(format);
            *(short*)_dataPointer = value;
            _dataPointer += sizeof(short);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(short? value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(short)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.Int16);
            AppendString(format);
            *(short*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(short);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(int value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(int)))
                return this;

            AppendArgumentType(ArgumentType.Int32);
            *(int*)_dataPointer = value;
            _dataPointer += sizeof(int);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(int? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(int)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Int32);
            *(int*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(int);
            return this;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(int value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(int)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.Int32);
            AppendString(format);
            *(int*)_dataPointer = value;
            _dataPointer += sizeof(int);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(int? value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(int)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.Int32);
            AppendString(format);
            *(int*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(int);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(long value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(long)))
                return this;

            AppendArgumentType(ArgumentType.Int64);
            *(long*)_dataPointer = value;
            _dataPointer += sizeof(long);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(long? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(long)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Int64);
            *(long*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(long);
            return this;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(long value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(long)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.Int64);
            AppendString(format);
            *(long*)_dataPointer = value;
            _dataPointer += sizeof(long);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(long? value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(long)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.Int64);
            AppendString(format);
            *(long*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(long);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(float value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(float)))
                return this;

            AppendArgumentType(ArgumentType.Single);
            *(float*)_dataPointer = value;
            _dataPointer += sizeof(float);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(float? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(float)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Single);
            *(float*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(float);
            return this;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(float value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(float)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.Single);
            AppendString(format);
            *(float*)_dataPointer = value;
            _dataPointer += sizeof(float);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(float? value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(float)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.Single);
            AppendString(format);
            *(float*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(float);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(double value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(double)))
                return this;

            AppendArgumentType(ArgumentType.Double);
            *(double*)_dataPointer = value;
            _dataPointer += sizeof(double);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(double? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(double)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Double);
            *(double*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(double);
            return this;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(double value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(double)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.Double);
            AppendString(format);
            *(double*)_dataPointer = value;
            _dataPointer += sizeof(double);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(double? value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(double)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.Double);
            AppendString(format);
            *(double*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(double);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(decimal value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(decimal)))
                return this;

            AppendArgumentType(ArgumentType.Decimal);
            *(decimal*)_dataPointer = value;
            _dataPointer += sizeof(decimal);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(decimal? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(decimal)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Decimal);
            *(decimal*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(decimal);
            return this;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(decimal value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(decimal)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.Decimal);
            AppendString(format);
            *(decimal*)_dataPointer = value;
            _dataPointer += sizeof(decimal);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(decimal? value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(decimal)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.Decimal);
            AppendString(format);
            *(decimal*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(decimal);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(Guid value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(Guid)))
                return this;

            AppendArgumentType(ArgumentType.Guid);
            *(Guid*)_dataPointer = value;
            _dataPointer += sizeof(Guid);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(Guid? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(Guid)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.Guid);
            *(Guid*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(Guid);
            return this;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(Guid value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(Guid)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.Guid);
            AppendString(format);
            *(Guid*)_dataPointer = value;
            _dataPointer += sizeof(Guid);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(Guid? value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(Guid)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.Guid);
            AppendString(format);
            *(Guid*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(Guid);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(DateTime value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(DateTime)))
                return this;

            AppendArgumentType(ArgumentType.DateTime);
            *(DateTime*)_dataPointer = value;
            _dataPointer += sizeof(DateTime);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(DateTime? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(DateTime)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.DateTime);
            *(DateTime*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(DateTime);
            return this;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(DateTime value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(DateTime)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.DateTime);
            AppendString(format);
            *(DateTime*)_dataPointer = value;
            _dataPointer += sizeof(DateTime);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(DateTime? value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(DateTime)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.DateTime);
            AppendString(format);
            *(DateTime*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(DateTime);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(TimeSpan value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(TimeSpan)))
                return this;

            AppendArgumentType(ArgumentType.TimeSpan);
            *(TimeSpan*)_dataPointer = value;
            _dataPointer += sizeof(TimeSpan);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(TimeSpan? value)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(TimeSpan)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentType(ArgumentType.TimeSpan);
            *(TimeSpan*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(TimeSpan);
            return this;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(TimeSpan value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(TimeSpan)))
                return this;

            AppendArgumentTypeWithFormat(ArgumentType.TimeSpan);
            AppendString(format);
            *(TimeSpan*)_dataPointer = value;
            _dataPointer += sizeof(TimeSpan);
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ILogEvent Append(TimeSpan? value, string format)
        {
            if (!PrepareAppend(sizeof(ArgumentType) + sizeof(byte) + sizeof(TimeSpan)))
                return this;

            if (value == null)
            {
                AppendArgumentType(ArgumentType.Null);
                return this;
            }

            AppendArgumentTypeWithFormat(ArgumentType.TimeSpan);
            AppendString(format);
            *(TimeSpan*)_dataPointer = value.GetValueOrDefault();
            _dataPointer += sizeof(TimeSpan);
            return this;
        }

    }

    partial class NoopLogEvent
    {
        public ILogEvent Append(bool value) => this;
        public ILogEvent Append(bool? value) => this;
        public ILogEvent Append(byte value) => this;
        public ILogEvent Append(byte? value) => this;
        public ILogEvent Append(byte value, string format) => this;
        public ILogEvent Append(byte? value, string format) => this;
        public ILogEvent Append(char value) => this;
        public ILogEvent Append(char? value) => this;
        public ILogEvent Append(short value) => this;
        public ILogEvent Append(short? value) => this;
        public ILogEvent Append(short value, string format) => this;
        public ILogEvent Append(short? value, string format) => this;
        public ILogEvent Append(int value) => this;
        public ILogEvent Append(int? value) => this;
        public ILogEvent Append(int value, string format) => this;
        public ILogEvent Append(int? value, string format) => this;
        public ILogEvent Append(long value) => this;
        public ILogEvent Append(long? value) => this;
        public ILogEvent Append(long value, string format) => this;
        public ILogEvent Append(long? value, string format) => this;
        public ILogEvent Append(float value) => this;
        public ILogEvent Append(float? value) => this;
        public ILogEvent Append(float value, string format) => this;
        public ILogEvent Append(float? value, string format) => this;
        public ILogEvent Append(double value) => this;
        public ILogEvent Append(double? value) => this;
        public ILogEvent Append(double value, string format) => this;
        public ILogEvent Append(double? value, string format) => this;
        public ILogEvent Append(decimal value) => this;
        public ILogEvent Append(decimal? value) => this;
        public ILogEvent Append(decimal value, string format) => this;
        public ILogEvent Append(decimal? value, string format) => this;
        public ILogEvent Append(Guid value) => this;
        public ILogEvent Append(Guid? value) => this;
        public ILogEvent Append(Guid value, string format) => this;
        public ILogEvent Append(Guid? value, string format) => this;
        public ILogEvent Append(DateTime value) => this;
        public ILogEvent Append(DateTime? value) => this;
        public ILogEvent Append(DateTime value, string format) => this;
        public ILogEvent Append(DateTime? value, string format) => this;
        public ILogEvent Append(TimeSpan value) => this;
        public ILogEvent Append(TimeSpan? value) => this;
        public ILogEvent Append(TimeSpan value, string format) => this;
        public ILogEvent Append(TimeSpan? value, string format) => this;
    }

    partial class ForwardingLogEvent
    {
        public ILogEvent Append(bool value) => this;
        public ILogEvent Append(bool? value) => this;
        public ILogEvent Append(byte value) => this;
        public ILogEvent Append(byte? value) => this;
        public ILogEvent Append(byte value, string format) => this;
        public ILogEvent Append(byte? value, string format) => this;
        public ILogEvent Append(char value) => this;
        public ILogEvent Append(char? value) => this;
        public ILogEvent Append(short value) => this;
        public ILogEvent Append(short? value) => this;
        public ILogEvent Append(short value, string format) => this;
        public ILogEvent Append(short? value, string format) => this;
        public ILogEvent Append(int value) => this;
        public ILogEvent Append(int? value) => this;
        public ILogEvent Append(int value, string format) => this;
        public ILogEvent Append(int? value, string format) => this;
        public ILogEvent Append(long value) => this;
        public ILogEvent Append(long? value) => this;
        public ILogEvent Append(long value, string format) => this;
        public ILogEvent Append(long? value, string format) => this;
        public ILogEvent Append(float value) => this;
        public ILogEvent Append(float? value) => this;
        public ILogEvent Append(float value, string format) => this;
        public ILogEvent Append(float? value, string format) => this;
        public ILogEvent Append(double value) => this;
        public ILogEvent Append(double? value) => this;
        public ILogEvent Append(double value, string format) => this;
        public ILogEvent Append(double? value, string format) => this;
        public ILogEvent Append(decimal value) => this;
        public ILogEvent Append(decimal? value) => this;
        public ILogEvent Append(decimal value, string format) => this;
        public ILogEvent Append(decimal? value, string format) => this;
        public ILogEvent Append(Guid value) => this;
        public ILogEvent Append(Guid? value) => this;
        public ILogEvent Append(Guid value, string format) => this;
        public ILogEvent Append(Guid? value, string format) => this;
        public ILogEvent Append(DateTime value) => this;
        public ILogEvent Append(DateTime? value) => this;
        public ILogEvent Append(DateTime value, string format) => this;
        public ILogEvent Append(DateTime? value, string format) => this;
        public ILogEvent Append(TimeSpan value) => this;
        public ILogEvent Append(TimeSpan? value) => this;
        public ILogEvent Append(TimeSpan value, string format) => this;
        public ILogEvent Append(TimeSpan? value, string format) => this;
    }
}
