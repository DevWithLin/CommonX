// File generated by hadoop record compiler. Do not edit.
/**
* Licensed to the Apache Software Foundation (ASF) under one
* or more contributor license agreements.  See the NOTICE file
* distributed with this work for additional information
* regarding copyright ownership.  The ASF licenses this file
* to you under the Apache License, Version 2.0 (the
* "License"); you may not use this file except in compliance
* with the License.  You may obtain a copy of the License at
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
using CommonX.Logging;
using Org.Apache.Jute;


namespace Org.Apache.Zookeeper.Txn
{
public class MultiTxn : IRecord, IComparable 
{
        private static readonly ILogger log;//;
        //private static readonly ILogger log;// = Scope.Resolve<ILoggerFactory>().Create(typeof(MultiTxn));
        public MultiTxn() {
  }
  public MultiTxn(
  System.Collections.Generic.IEnumerable<Org.Apache.Zookeeper.Txn.Txn> txns
) {
Txns=txns;
  }
  public System.Collections.Generic.IEnumerable<Org.Apache.Zookeeper.Txn.Txn> Txns { get; set; } 
  public void Serialize(IOutputArchive a_, String tag) {
    a_.StartRecord(this,tag);
    {
      a_.StartVector(Txns,"txns");
      if (Txns!= null) {          foreach(var e1 in Txns) {
    a_.WriteRecord(e1,"e1");
          }
      }
      a_.EndVector(Txns,"txns");
    }
    a_.EndRecord(this,tag);
  }
  public void Deserialize(IInputArchive a_, String tag) {
    a_.StartRecord(tag);
    {
      IIndex vidx1 = a_.StartVector("txns");
      if (vidx1!= null) {          var tmpLst=new System.Collections.Generic.List<Org.Apache.Zookeeper.Txn.Txn>();
          for (; !vidx1.Done(); vidx1.Incr()) {
    Org.Apache.Zookeeper.Txn.Txn e1;
    e1= new Org.Apache.Zookeeper.Txn.Txn();
    a_.ReadRecord(e1,"e1");
            tmpLst.Add(e1);
          }
            Txns=tmpLst;
      }
    a_.EndVector("txns");
    }
    a_.EndRecord(tag);
}
  public override String ToString() {
    try {
      System.IO.MemoryStream ms = new System.IO.MemoryStream();
      using(ZooKeeperNet.IO.EndianBinaryWriter writer =
        new ZooKeeperNet.IO.EndianBinaryWriter(ZooKeeperNet.IO.EndianBitConverter.Big, ms, System.Text.Encoding.UTF8)){
      BinaryOutputArchive a_ = 
        new BinaryOutputArchive(writer);
      a_.StartRecord(this,string.Empty);
    {
      a_.StartVector(Txns,"txns");
      if (Txns!= null) {          foreach(var e1 in Txns) {
    a_.WriteRecord(e1,"e1");
          }
      }
      a_.EndVector(Txns,"txns");
    }
      a_.EndRecord(this,string.Empty);
      ms.Position = 0;
      return System.Text.Encoding.UTF8.GetString(ms.ToArray());
    }    } catch (Exception ex) {
      log.Error(ex);
    }
    return "ERROR";
  }
  public void Write(ZooKeeperNet.IO.EndianBinaryWriter writer) {
    BinaryOutputArchive archive = new BinaryOutputArchive(writer);
    Serialize(archive, string.Empty);
  }
  public void ReadFields(ZooKeeperNet.IO.EndianBinaryReader reader) {
    BinaryInputArchive archive = new BinaryInputArchive(reader);
    Deserialize(archive, string.Empty);
  }
  public int CompareTo (object obj) {
    throw new InvalidOperationException("comparing MultiTxn is unimplemented");
  }
  public override bool Equals(object obj) {
 MultiTxn peer = (MultiTxn) obj;
    if (peer == null) {
      return false;
    }
    if (Object.ReferenceEquals(peer,this)) {
      return true;
    }
    bool ret = false;
    ret = Txns.Equals(peer.Txns);
    if (!ret) return ret;
     return ret;
  }
  public override int GetHashCode() {
    int result = 17;
    int ret = GetType().GetHashCode();
    result = 37*result + ret;
    ret = Txns.GetHashCode();
    result = 37*result + ret;
    return result;
  }
  public static string Signature() {
    return "LMultiTxn([LTxn(iB)])";
  }
}
}
