﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefSslStatus : IDisposable
    {
        internal static CefSslStatus FromNative(cef_sslstatus_t* ptr)
        {
            return new CefSslStatus(ptr);
        }
        
        internal static CefSslStatus FromNativeOrNull(cef_sslstatus_t* ptr)
        {
            if (ptr == null) return null;
            return new CefSslStatus(ptr);
        }
        
        private cef_sslstatus_t* _self;
        
        private CefSslStatus(cef_sslstatus_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefSslStatus()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal void AddRef()
        {
            cef_sslstatus_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_sslstatus_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_sslstatus_t.has_one_ref(_self) != 0; }
        }
        
        internal cef_sslstatus_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
