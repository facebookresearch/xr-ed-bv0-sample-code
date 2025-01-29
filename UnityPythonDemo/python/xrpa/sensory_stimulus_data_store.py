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

import typing
import xrpa.sensory_stimulus_types
import xrpa_runtime.reconciler.collection_change_types
import xrpa_runtime.reconciler.data_store_interfaces
import xrpa_runtime.reconciler.data_store_reconciler
import xrpa_runtime.reconciler.object_collection
import xrpa_runtime.transport.transport_stream
import xrpa_runtime.transport.transport_stream_accessor
import xrpa_runtime.utils.memory_accessor
import xrpa_runtime.utils.time_utils
import xrpa_runtime.utils.xrpa_types

class StimulusReader(xrpa_runtime.utils.xrpa_types.ObjectAccessorInterface):
  def __init__(self, mem_accessor: xrpa_runtime.utils.memory_accessor.MemoryAccessor):
    super().__init__(mem_accessor)

  def get_pose(self) -> xrpa.sensory_stimulus_types.Pose:
    return xrpa.sensory_stimulus_types.DSPose.read_value(self._mem_accessor, self.advance_read_pos(28))

  def get_visual_delay(self) -> float:
    return xrpa.sensory_stimulus_types.DSScalar.read_value(self._mem_accessor, self.advance_read_pos(4))

  def get_audio_delay(self) -> float:
    return xrpa.sensory_stimulus_types.DSScalar.read_value(self._mem_accessor, self.advance_read_pos(4))

  def check_pose_changed(self, fields_changed: int) -> bool:
    return (fields_changed & 1) != 0

  def check_visual_delay_changed(self, fields_changed: int) -> bool:
    return (fields_changed & 2) != 0

  def check_audio_delay_changed(self, fields_changed: int) -> bool:
    return (fields_changed & 4) != 0

class StimulusWriter(StimulusReader):
  def __init__(self, mem_accessor: xrpa_runtime.utils.memory_accessor.MemoryAccessor):
    super().__init__(mem_accessor)

  @staticmethod
  def create(accessor: xrpa_runtime.transport.transport_stream_accessor.TransportStreamAccessor, collection_id: int, id: xrpa_runtime.utils.xrpa_types.ObjectUuid, change_byte_count: int, timestamp: int) -> "StimulusWriter":
    change_event = accessor.write_change_event(xrpa_runtime.reconciler.collection_change_types.CollectionChangeEventAccessor, xrpa_runtime.reconciler.collection_change_types.CollectionChangeType.CreateObject.value, change_byte_count, timestamp)
    change_event.set_collection_id(collection_id)
    change_event.set_object_id(id)
    return StimulusWriter(change_event.access_change_data())

  @staticmethod
  def update(accessor: xrpa_runtime.transport.transport_stream_accessor.TransportStreamAccessor, collection_id: int, id: xrpa_runtime.utils.xrpa_types.ObjectUuid, fields_changed: int, change_byte_count: int) -> "StimulusWriter":
    change_event = accessor.write_change_event(xrpa_runtime.reconciler.collection_change_types.CollectionUpdateChangeEventAccessor, xrpa_runtime.reconciler.collection_change_types.CollectionChangeType.UpdateObject.value, change_byte_count)
    change_event.set_collection_id(collection_id)
    change_event.set_object_id(id)
    change_event.set_fields_changed(fields_changed)
    return StimulusWriter(change_event.access_change_data())

  def set_pose(self, value: xrpa.sensory_stimulus_types.Pose) -> None:
    xrpa.sensory_stimulus_types.DSPose.write_value(value, self._mem_accessor, self.advance_write_pos(28))

  def set_visual_delay(self, value: float) -> None:
    xrpa.sensory_stimulus_types.DSScalar.write_value(value, self._mem_accessor, self.advance_write_pos(4))

  def set_audio_delay(self, value: float) -> None:
    xrpa.sensory_stimulus_types.DSScalar.write_value(value, self._mem_accessor, self.advance_write_pos(4))

# Reconciled Types
class OutboundStimulus(xrpa_runtime.reconciler.data_store_interfaces.DataStoreObject, xrpa_runtime.reconciler.data_store_interfaces.IDataStoreObjectAccessor[StimulusReader]):
  def __init__(self, id: xrpa_runtime.utils.xrpa_types.ObjectUuid):
    super().__init__(id, None)
    self._create_timestamp = xrpa_runtime.utils.time_utils.TimeUtils.get_current_clock_time_microseconds()
    self._user_response_message_handler = None
    self._local_pose = xrpa.sensory_stimulus_types.Pose(xrpa.sensory_stimulus_types.Vector3(0, 0, 0), xrpa.sensory_stimulus_types.Quaternion(0, 0, 0, 1))
    self._local_visual_delay = 1
    self._local_audio_delay = 1
    self._change_bits = 0
    self._change_byte_count = 0
    self._create_written = False

  def get_pose(self) -> xrpa.sensory_stimulus_types.Pose:
    return self._local_pose

  def set_pose(self, pose: xrpa.sensory_stimulus_types.Pose) -> None:
    self._local_pose = pose
    if (self._change_bits & 1) == 0:
      self._change_bits |= 1
      self._change_byte_count += 28
    if self._collection is not None:
      if not self._has_notified_needs_write:
        self._collection.notify_object_needs_write(self.get_xrpa_id())
        self._has_notified_needs_write = True
      self._collection.set_dirty(self.get_xrpa_id(), 1)

  def get_visual_delay(self) -> float:
    return self._local_visual_delay

  def set_visual_delay(self, visual_delay: float) -> None:
    self._local_visual_delay = visual_delay
    if (self._change_bits & 2) == 0:
      self._change_bits |= 2
      self._change_byte_count += 4
    if self._collection is not None:
      if not self._has_notified_needs_write:
        self._collection.notify_object_needs_write(self.get_xrpa_id())
        self._has_notified_needs_write = True
      self._collection.set_dirty(self.get_xrpa_id(), 2)

  def get_audio_delay(self) -> float:
    return self._local_audio_delay

  def set_audio_delay(self, audio_delay: float) -> None:
    self._local_audio_delay = audio_delay
    if (self._change_bits & 4) == 0:
      self._change_bits |= 4
      self._change_byte_count += 4
    if self._collection is not None:
      if not self._has_notified_needs_write:
        self._collection.notify_object_needs_write(self.get_xrpa_id())
        self._has_notified_needs_write = True
      self._collection.set_dirty(self.get_xrpa_id(), 4)

  def write_ds_changes(self, accessor: xrpa_runtime.transport.transport_stream_accessor.TransportStreamAccessor) -> None:
    obj_accessor = None
    if not self._create_written:
      self._change_bits = 7
      self._change_byte_count = 36
      obj_accessor = StimulusWriter.create(accessor, self.get_collection_id(), self.get_xrpa_id(), self._change_byte_count, self._create_timestamp)
      self._create_written = True
    elif self._change_bits != 0:
      obj_accessor = StimulusWriter.update(accessor, self.get_collection_id(), self.get_xrpa_id(), self._change_bits, self._change_byte_count)
    if obj_accessor is None or obj_accessor.is_null():
      return
    if (self._change_bits & 1) != 0:
      obj_accessor.set_pose(self._local_pose)
    if (self._change_bits & 2) != 0:
      obj_accessor.set_visual_delay(self._local_visual_delay)
    if (self._change_bits & 4) != 0:
      obj_accessor.set_audio_delay(self._local_audio_delay)
    self._change_bits = 0
    self._change_byte_count = 0
    self._has_notified_needs_write = False

  def prep_ds_full_update(self) -> int:
    self._create_written = False
    self._change_bits = 7
    self._change_byte_count = 36
    return self._create_timestamp

  def process_ds_update(self, value: StimulusReader, fields_changed: int) -> None:
    pass

  def on_user_response(self, handler: typing.Callable[[int], None]) -> None:
    self._user_response_message_handler = handler

  def process_ds_message(self, message_type: int, timestamp: int, message_data: xrpa_runtime.utils.memory_accessor.MemoryAccessor) -> None:
    if message_type == 3 and self._user_response_message_handler is not None:
      self._user_response_message_handler(timestamp)

# Object Collections
class OutboundStimulusReaderCollection(xrpa_runtime.reconciler.object_collection.ObjectCollection[StimulusReader, OutboundStimulus]):
  def __init__(self, reconciler: xrpa_runtime.reconciler.data_store_reconciler.DataStoreReconciler):
    super().__init__(StimulusReader, reconciler, 0, 0, 0, True)

  def add_object(self, obj: OutboundStimulus) -> None:
    self._add_object_internal(obj)

  def remove_object(self, id: xrpa_runtime.utils.xrpa_types.ObjectUuid) -> None:
    self._remove_object_internal(id)

# Data Store Implementation
class SensoryStimulusDataStore(xrpa_runtime.reconciler.data_store_reconciler.DataStoreReconciler):
  def __init__(self, inbound_transport: xrpa_runtime.transport.transport_stream.TransportStream, outbound_transport: xrpa_runtime.transport.transport_stream.TransportStream):
    super().__init__(inbound_transport, outbound_transport, 57344)
    self.Stimulus = OutboundStimulusReaderCollection(self)
    self._register_collection(self.Stimulus)
