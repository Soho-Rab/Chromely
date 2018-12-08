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
    public sealed unsafe partial class CefJSDialogCallback : IDisposable
    {
        internal static CefJSDialogCallback FromNative(cef_jsdialog_callback_t* ptr)
        {
            return new CefJSDialogCallback(ptr);
        }
        
        internal static CefJSDialogCallback FromNativeOrNull(cef_jsdialog_callback_t* ptr)
        {
            if (ptr == null) return null;
            return new CefJSDialogCallback(ptr);
        }
        
        private cef_jsdialog_callback_t* _self;
        
        private CefJSDialogCallback(cef_jsdialog_callback_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefJSDialogCallback()
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
            cef_jsdialog_callback_t.add_ref(_self);
        }
        
        internal bool Release()
        {
            return cef_jsdialog_callback_t.release(_self) != 0;
        }
        
        internal bool HasOneRef
        {
            get { return cef_jsdialog_callback_t.has_one_ref(_self) != 0; }
        }
        
        internal cef_jsdialog_callback_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
