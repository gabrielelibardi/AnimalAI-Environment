// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: animalai/communicator_objects/unity_rl_reset_input.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from animalai/communicator_objects/unity_rl_reset_input.proto</summary>
  public static partial class UnityRlResetInputReflection {

    #region Descriptor
    /// <summary>File descriptor for animalai/communicator_objects/unity_rl_reset_input.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityRlResetInputReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhhbmltYWxhaS9jb21tdW5pY2F0b3Jfb2JqZWN0cy91bml0eV9ybF9yZXNl",
            "dF9pbnB1dC5wcm90bxIUY29tbXVuaWNhdG9yX29iamVjdHMaOmFuaW1hbGFp",
            "L2NvbW11bmljYXRvcl9vYmplY3RzL2FyZW5hX3BhcmFtZXRlcnNfcHJvdG8u",
            "cHJvdG8iswEKEVVuaXR5UkxSZXNldElucHV0EkMKBmFyZW5hcxgBIAMoCzIz",
            "LmNvbW11bmljYXRvcl9vYmplY3RzLlVuaXR5UkxSZXNldElucHV0LkFyZW5h",
            "c0VudHJ5GlkKC0FyZW5hc0VudHJ5EgsKA2tleRgBIAEoBRI5CgV2YWx1ZRgC",
            "IAEoCzIqLmNvbW11bmljYXRvcl9vYmplY3RzLkFyZW5hUGFyYW1ldGVyc1By",
            "b3RvOgI4AUIfqgIcTUxBZ2VudHMuQ29tbXVuaWNhdG9yT2JqZWN0c2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MLAgents.CommunicatorObjects.ArenaParametersProtoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MLAgents.CommunicatorObjects.UnityRLResetInput), global::MLAgents.CommunicatorObjects.UnityRLResetInput.Parser, new[]{ "Arenas" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UnityRLResetInput : pb::IMessage<UnityRLResetInput> {
    private static readonly pb::MessageParser<UnityRLResetInput> _parser = new pb::MessageParser<UnityRLResetInput>(() => new UnityRLResetInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnityRLResetInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MLAgents.CommunicatorObjects.UnityRlResetInputReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLResetInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLResetInput(UnityRLResetInput other) : this() {
      arenas_ = other.arenas_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityRLResetInput Clone() {
      return new UnityRLResetInput(this);
    }

    /// <summary>Field number for the "arenas" field.</summary>
    public const int ArenasFieldNumber = 1;
    private static readonly pbc::MapField<int, global::MLAgents.CommunicatorObjects.ArenaParametersProto>.Codec _map_arenas_codec
        = new pbc::MapField<int, global::MLAgents.CommunicatorObjects.ArenaParametersProto>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForMessage(18, global::MLAgents.CommunicatorObjects.ArenaParametersProto.Parser), 10);
    private readonly pbc::MapField<int, global::MLAgents.CommunicatorObjects.ArenaParametersProto> arenas_ = new pbc::MapField<int, global::MLAgents.CommunicatorObjects.ArenaParametersProto>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, global::MLAgents.CommunicatorObjects.ArenaParametersProto> Arenas {
      get { return arenas_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnityRLResetInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnityRLResetInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Arenas.Equals(other.Arenas)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Arenas.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      arenas_.WriteTo(output, _map_arenas_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += arenas_.CalculateSize(_map_arenas_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnityRLResetInput other) {
      if (other == null) {
        return;
      }
      arenas_.Add(other.arenas_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            arenas_.AddEntriesFrom(input, _map_arenas_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code