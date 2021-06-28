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

namespace NodeApi
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class WalletData : TBase
  {
    private int _walletId;
    private NodeApi.Amount _balance;
    private long _lastTransactionId;
    private Delegated _delegated;

    public int WalletId
    {
      get
      {
        return _walletId;
      }
      set
      {
        __isset.walletId = true;
        this._walletId = value;
      }
    }

    public NodeApi.Amount Balance
    {
      get
      {
        return _balance;
      }
      set
      {
        __isset.balance = true;
        this._balance = value;
      }
    }

    public long LastTransactionId
    {
      get
      {
        return _lastTransactionId;
      }
      set
      {
        __isset.lastTransactionId = true;
        this._lastTransactionId = value;
      }
    }

    public Delegated Delegated
    {
      get
      {
        return _delegated;
      }
      set
      {
        __isset.delegated = true;
        this._delegated = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool walletId;
      public bool balance;
      public bool lastTransactionId;
      public bool delegated;
    }

    public WalletData() {
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
              if (field.Type == TType.I32) {
                WalletId = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                Balance = new NodeApi.Amount();
                Balance.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I64) {
                LastTransactionId = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Struct) {
                Delegated = new Delegated();
                Delegated.Read(iprot);
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
        TStruct struc = new TStruct("WalletData");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.walletId) {
          field.Name = "walletId";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(WalletId);
          oprot.WriteFieldEnd();
        }
        if (Balance != null && __isset.balance) {
          field.Name = "balance";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          Balance.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.lastTransactionId) {
          field.Name = "lastTransactionId";
          field.Type = TType.I64;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(LastTransactionId);
          oprot.WriteFieldEnd();
        }
        if (Delegated != null && __isset.delegated) {
          field.Name = "delegated";
          field.Type = TType.Struct;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          Delegated.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("WalletData(");
      bool __first = true;
      if (__isset.walletId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("WalletId: ");
        __sb.Append(WalletId);
      }
      if (Balance != null && __isset.balance) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Balance: ");
        __sb.Append(Balance== null ? "<null>" : Balance.ToString());
      }
      if (__isset.lastTransactionId) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("LastTransactionId: ");
        __sb.Append(LastTransactionId);
      }
      if (Delegated != null && __isset.delegated) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Delegated: ");
        __sb.Append(Delegated== null ? "<null>" : Delegated.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
