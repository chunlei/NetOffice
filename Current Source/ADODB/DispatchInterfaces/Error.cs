//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// DispatchInterface Error 
	/// SupportByLibrary ADODB, 2.1,2.5
	///</summary>
	[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Error : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Error);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Error(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Error(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Error(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Error() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Error(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
		public Int32 Number
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Number", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
		public string Source
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Source", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
		public string Description
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Description", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
		public string HelpFile
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HelpFile", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
		public Int32 HelpContext
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HelpContext", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
		public string SQLState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SQLState", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary ADODB 2.1, 2.5
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("ADODB", 2.1,2.5)]
		public Int32 NativeError
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NativeError", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}