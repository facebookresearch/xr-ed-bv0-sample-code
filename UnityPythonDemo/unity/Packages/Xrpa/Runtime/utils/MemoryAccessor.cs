/*
// @generated
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Text;

namespace Xrpa
{

    public class MemoryOffset
    {
        public MemoryOffset(int offset = 0)
        {
            _offset = offset;
        }

        public int Advance(int numBytes)
        {
            var pos = _offset;
            _offset += numBytes;
            return pos;
        }

        public int _offset;
    }

    unsafe public class MemoryAccessor
    {
        public MemoryAccessor() { }

        public MemoryAccessor(byte* dataSource, long offset, long size)
        {
            _dataSource = dataSource;
            _memOffset = offset;
            _size = (int)size;
        }

        public long MemOffset => _memOffset;
        public byte* DataSource => _dataSource;
        public int Size => _size;

        private readonly byte* _dataSource;
        private readonly long _memOffset;
        private readonly int _size;

        public MemoryAccessor Slice(long offset, long size = -1)
        {
            if (size < 0 || size > _size - offset)
            {
                size = _size - offset;
            }
            if (size < 0)
            {
                size = 0;
            }
            XrpaUtils.BoundsAssert((int)offset, (int)size, 0, _size);
            return new MemoryAccessor(_dataSource, _memOffset + offset, size);
        }

        public bool IsNull()
        {
            return _dataSource == null || _size == 0;
        }

        public void WriteToZeros()
        {
            MemoryOffset writePos = new();
            while (writePos._offset < _size)
            {
                if (_size - writePos._offset >= 8)
                {
                    WriteUlong(0, writePos);
                }
                else if (_size - writePos._offset >= 4)
                {
                    WriteInt(0, writePos);
                }
                else
                {
                    WriteByte(0, writePos);
                }
            }
        }

        public void CopyFrom(MemoryAccessor other)
        {
            if (other.IsNull())
            {
                return;
            }
            int size = other.Size < _size ? other.Size : _size;
            MemoryOffset readPos = new();
            MemoryOffset writePos = new();
            while (readPos._offset < size)
            {
                if (size - readPos._offset >= 8)
                {
                    WriteUlong(other.ReadUlong(readPos), writePos);
                }
                else if (size - readPos._offset >= 4)
                {
                    WriteInt(other.ReadInt(readPos), writePos);
                }
                else
                {
                    WriteByte(other.ReadByte(readPos), writePos);
                }
            }
        }

        public byte ReadByte(MemoryOffset offset)
        {
            XrpaUtils.BoundsAssert(offset._offset, 1, 0, _size);
            return *(_dataSource + _memOffset + offset.Advance(1));
        }

        public void WriteByte(byte val, MemoryOffset offset)
        {
            XrpaUtils.BoundsAssert(offset._offset, 1, 0, _size);
            *(_dataSource + _memOffset + offset.Advance(1)) = val;
        }

        public int ReadInt(MemoryOffset offset)
        {
            XrpaUtils.BoundsAssert(offset._offset, 4, 0, _size);
            return *((int*)(_dataSource + _memOffset + offset.Advance(4)));
        }

        public void WriteInt(int val, MemoryOffset offset)
        {
            XrpaUtils.BoundsAssert(offset._offset, 4, 0, _size);
            *((int*)(_dataSource + _memOffset + offset.Advance(4))) = val;
        }

        public uint ReadUint(MemoryOffset offset)
        {
            XrpaUtils.BoundsAssert(offset._offset, 4, 0, _size);
            return *((uint*)(_dataSource + _memOffset + offset.Advance(4)));
        }

        public void WriteUint(uint val, MemoryOffset offset)
        {
            XrpaUtils.BoundsAssert(offset._offset, 4, 0, _size);
            *((uint*)(_dataSource + _memOffset + offset.Advance(4))) = val;
        }

        public float ReadFloat(MemoryOffset offset)
        {
            XrpaUtils.BoundsAssert(offset._offset, 4, 0, _size);
            return *((float*)(_dataSource + _memOffset + offset.Advance(4)));
        }

        public void WriteFloat(float val, MemoryOffset offset)
        {
            XrpaUtils.BoundsAssert(offset._offset, 4, 0, _size);
            *((float*)(_dataSource + _memOffset + offset.Advance(4))) = val;
        }

        public ulong ReadUlong(MemoryOffset offset)
        {
            XrpaUtils.BoundsAssert(offset._offset, 8, 0, _size);
            return *((ulong*)(_dataSource + _memOffset + offset.Advance(8)));
        }

        public void WriteUlong(ulong val, MemoryOffset offset)
        {
            XrpaUtils.BoundsAssert(offset._offset, 8, 0, _size);
            *((ulong*)(_dataSource + _memOffset + offset.Advance(8))) = val;
        }

        public string ReadString(MemoryOffset offset)
        {
            byte[] byteArray = ReadBytes(offset);
            return Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
        }

        public void WriteString(string val, MemoryOffset offset)
        {
            WriteBytes(Encoding.UTF8.GetBytes(val), offset);
        }

        public static int DynSizeOfString(string val)
        {
            return Encoding.UTF8.GetBytes(val).Length;
        }

        public byte[] ReadBytes(MemoryOffset offset)
        {
            int byteCount = ReadInt(offset);
            int strOffset = offset.Advance(byteCount);
            XrpaUtils.BoundsAssert(strOffset, byteCount, 0, _size);
            byte[] byteArray = new byte[byteCount];
            for (int i = 0; i < byteCount; i++)
            {
                byteArray[i] = *(_dataSource + _memOffset + strOffset + i);
            }
            return byteArray;
        }

        public void WriteBytes(byte[] val, MemoryOffset offset)
        {
            int byteCount = val.Length;
            WriteInt(byteCount, offset);

            int strOffset = offset.Advance(byteCount);
            XrpaUtils.BoundsAssert(strOffset, byteCount, 0, _size);
            for (int i = 0; i < byteCount; i++)
            {
                *(_dataSource + _memOffset + strOffset + i) = val[i];
            }
        }

        public static int DynSizeOfBytes(byte[] val)
        {
            return val.Length;
        }
    }

}
