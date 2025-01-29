# Copyright (c) Meta Platforms, Inc. and affiliates.
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

# @generated

import dataclasses
import xrpa_runtime.utils.memory_accessor
import xrpa_runtime.utils.xrpa_types

class sensory_stimulus_data_store_config:
  transport_config = xrpa_runtime.utils.xrpa_types.TransportConfig(xrpa_runtime.utils.xrpa_types.HashValue(0xca3eb487614d2465, 0xb66cd98da96fe6ff, 0x9bb9f8e39e1365c7, 0xb2a7d062da38976d), 61952)

@dataclasses.dataclass
class Vector3:
  x: float
  y: float
  z: float

@dataclasses.dataclass
class Quaternion:
  x: float
  y: float
  z: float
  w: float

@dataclasses.dataclass
class Pose:
  position: Vector3
  orientation: Quaternion

@dataclasses.dataclass
class DSVector3:
  @staticmethod
  def read_value(mem_accessor: xrpa_runtime.utils.memory_accessor.MemoryAccessor, offset: int) -> Vector3:
    x = mem_accessor.read_float(offset + 0)
    y = mem_accessor.read_float(offset + 4)
    z = mem_accessor.read_float(offset + 8)
    return Vector3(x, y, -z)

  @staticmethod
  def write_value(val: Vector3, mem_accessor: xrpa_runtime.utils.memory_accessor.MemoryAccessor, offset: int) -> None:
    mem_accessor.write_float(val.x, offset + 0)
    mem_accessor.write_float(val.y, offset + 4)
    mem_accessor.write_float(-val.z, offset + 8)

@dataclasses.dataclass
class DSQuaternion:
  @staticmethod
  def read_value(mem_accessor: xrpa_runtime.utils.memory_accessor.MemoryAccessor, offset: int) -> Quaternion:
    x = mem_accessor.read_float(offset + 0)
    y = mem_accessor.read_float(offset + 4)
    z = mem_accessor.read_float(offset + 8)
    w = mem_accessor.read_float(offset + 12)
    return Quaternion(-x, -y, z, w)

  @staticmethod
  def write_value(val: Quaternion, mem_accessor: xrpa_runtime.utils.memory_accessor.MemoryAccessor, offset: int) -> None:
    mem_accessor.write_float(-val.x, offset + 0)
    mem_accessor.write_float(-val.y, offset + 4)
    mem_accessor.write_float(val.z, offset + 8)
    mem_accessor.write_float(val.w, offset + 12)

@dataclasses.dataclass
class DSPose:
  @staticmethod
  def read_value(mem_accessor: xrpa_runtime.utils.memory_accessor.MemoryAccessor, offset: int) -> Pose:
    position = DSVector3.read_value(mem_accessor, offset + 0)
    orientation = DSQuaternion.read_value(mem_accessor, offset + 12)
    return Pose(position, orientation)

  @staticmethod
  def write_value(val: Pose, mem_accessor: xrpa_runtime.utils.memory_accessor.MemoryAccessor, offset: int) -> None:
    DSVector3.write_value(val.position, mem_accessor, offset + 0)
    DSQuaternion.write_value(val.orientation, mem_accessor, offset + 12)

@dataclasses.dataclass
class DSScalar:
  @staticmethod
  def read_value(mem_accessor: xrpa_runtime.utils.memory_accessor.MemoryAccessor, offset: int) -> float:
    value = mem_accessor.read_float(offset + 0)
    return value

  @staticmethod
  def write_value(val: float, mem_accessor: xrpa_runtime.utils.memory_accessor.MemoryAccessor, offset: int) -> None:
    mem_accessor.write_float(val, offset + 0)
