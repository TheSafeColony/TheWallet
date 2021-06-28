/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NodeApiDiag
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ContractCall : TBase
  {
    private bool _getter;
    private string _method;
    private List<NodeApi.Variant> _params;
    private List<byte[]> _uses;

    public bool Getter
    {
      get
      {
        return _getter;
      }
      set
      {
        __isset.getter = true;
        this._getter = value;
      }
    }

    public string Method
    {
      get
      {
        return _method;
      }
      set
      {
        __isset.method = true;
        this._method = value;
      }
    }

    public List<NodeApi.Variant> Params
    {
      get
      {
        return _params;
      }
      set
      {
        __isset.@params = true;
        this._params = value;
      }
    }

    public List<byte[]> Uses
    {
      get
      {
        return _uses;
      }
      set
      {
        __isset.uses = true;
        this._uses = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool getter;
      public bool method;
      public bool @params;
      public bool uses;
    }

    public ContractCall() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Bool) {
                Getter = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Method = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.List) {
                {
                  Params = new List<NodeApi.Variant>();
                  TList _list4 = iprot.ReadListBegin();
                  for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                  {
                    NodeApi.Variant _elem6;
                    _elem6 = new NodeApi.Variant();
                    _elem6.Read(iprot);
                    Params.Add(_elem6);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.List) {
                {
                  Uses = new List<byte[]>();
                  TList _list7 = iprot.ReadListBegin();
                  for( int _i8 = 0; _i8 < _list7.Count; ++_i8)
                  {
                    byte[] _elem9;
                    _elem9 = iprot.ReadBinary();
                    Uses.Add(_elem9);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("ContractCall");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.getter) {
          field.Name = "getter";
          field.Type = TType.Bool;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Getter);
          oprot.WriteFieldEnd();
        }
        if (Method != null && __isset.method) {
          field.Name = "method";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Method);
          oprot.WriteFieldEnd();
        }
        if (Params != null && __isset.@params) {
          field.Name = "params";
          field.Type = TType.List;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Params.Count));
            foreach (NodeApi.Variant _iter10 in Params)
            {
              _iter10.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Uses != null && __isset.uses) {
          field.Name = "uses";
          field.Type = TType.List;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.String, Uses.Count));
            foreach (byte[] _iter11 in Uses)
            {
              oprot.WriteBinary(_iter11);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("ContractCall(");
      bool __first = true;
      if (__isset.getter) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Getter: ");
        __sb.Append(Getter);
      }
      if (Method != null && __isset.method) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Method: ");
        __sb.Append(Method);
      }
      if (Params != null && __isset.@params) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Params: ");
        __sb.Append(Params);
      }
      if (Uses != null && __isset.uses) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Uses: ");
        __sb.Append(Uses);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
