﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommonX.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JZTERP.Frameworks.Common.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Timestamp: {Timestamp}
        ///ReferenceId: {ReferenceId}
        ///Severity: {Severity}
        ///MessageType: {MessageType}
        ///DurationInDays: {DurationInDays}
        ///InputRequest: {InputRequest}
        ///Origin.Server: {Origin.Server}
        ///Origin.Application: {Origin.Application}
        ///Origin.CallingApplication: {Origin.CallingApplication}
        ///Origin.ServiceName: {Origin.ServiceName}
        ///Origin.Operation: {Origin.Operation}
        ///Origin.Component: {Origin.Component}
        ///Origin.Method: {Origin.Method}
        ///Customer.CustomerCode: {Customer.CustomerCode}
        ///Customer.UserId: { [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string DefaultTextFormat {
            get {
                return ResourceManager.GetString("DefaultTextFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Disconnected, has tried to re-build connection but some logs might not be sent. 的本地化字符串。
        /// </summary>
        internal static string DisconnectedMessage {
            get {
                return ResourceManager.GetString("DisconnectedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 EmsListener failed to send log messages. 的本地化字符串。
        /// </summary>
        internal static string EmsListenerException {
            get {
                return ResourceManager.GetString("EmsListenerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 EmsListener failed to send log messages asynchronously. 的本地化字符串。
        /// </summary>
        internal static string EmsListenerFailedAsynchronously {
            get {
                return ResourceManager.GetString("EmsListenerFailedAsynchronously", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unexpected error in 的本地化字符串。
        /// </summary>
        internal static string EventLogException {
            get {
                return ResourceManager.GetString("EventLogException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Data: 的本地化字符串。
        /// </summary>
        internal static string ExceptionFormatterDataLabel {
            get {
                return ResourceManager.GetString("ExceptionFormatterDataLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 --- end of inner exception --- 的本地化字符串。
        /// </summary>
        internal static string ExceptionFormatterEndOfInnerException {
            get {
                return ResourceManager.GetString("ExceptionFormatterEndOfInnerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Exception: 的本地化字符串。
        /// </summary>
        internal static string ExceptionFormatterExceptionLabel {
            get {
                return ResourceManager.GetString("ExceptionFormatterExceptionLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 StackTrace: 的本地化字符串。
        /// </summary>
        internal static string ExceptionFormatterStackTraceLabel {
            get {
                return ResourceManager.GetString("ExceptionFormatterStackTraceLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to read intrinsic property.  Error message: {0} 的本地化字符串。
        /// </summary>
        internal static string IntrinsicPropertyError {
            get {
                return ResourceManager.GetString("IntrinsicPropertyError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Permission for UnmanagedCode is not available. 的本地化字符串。
        /// </summary>
        internal static string LogEntryIntrinsicPropertyNoUnmanagedCodePermissionError {
            get {
                return ResourceManager.GetString("LogEntryIntrinsicPropertyNoUnmanagedCodePermissionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This method is not implemented. 的本地化字符串。
        /// </summary>
        internal static string MethodNotImplemented {
            get {
                return ResourceManager.GetString("MethodNotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {nameToMonitor} completed in {durationInSeconds} seconds.  But the {thresholdName} threshold is {thresholdValue} seconds. 的本地化字符串。
        /// </summary>
        internal static string MonitorMessageTextThresholdExceeded {
            get {
                return ResourceManager.GetString("MonitorMessageTextThresholdExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {nameToMonitor} completed in {durationInSeconds} seconds. 的本地化字符串。
        /// </summary>
        internal static string MonitorMessageTextTimerUsage {
            get {
                return ResourceManager.GetString("MonitorMessageTextTimerUsage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {nameToMonitor} Start 的本地化字符串。
        /// </summary>
        internal static string MonitorMessageTextTraceStart {
            get {
                return ResourceManager.GetString("MonitorMessageTextTraceStart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {nameToMonitor} Stop ({durationInSeconds} seconds) 的本地化字符串。
        /// </summary>
        internal static string MonitorMessageTextTraceStop {
            get {
                return ResourceManager.GetString("MonitorMessageTextTraceStop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Configuration was not found for EMSListener 的本地化字符串。
        /// </summary>
        internal static string NotConfigured {
            get {
                return ResourceManager.GetString("NotConfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Processing attempt {count} failed - another attempt will be made. 的本地化字符串。
        /// </summary>
        internal static string ProcessingAttemptFailedButTryingAgain {
            get {
                return ResourceManager.GetString("ProcessingAttemptFailedButTryingAgain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {count} attempts failed - log was not successfully processed. 的本地化字符串。
        /// </summary>
        internal static string ProcessingAttemptsFailed {
            get {
                return ResourceManager.GetString("ProcessingAttemptsFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Attempt {AttemptCount} failed after {ExecutionTimeInSeconds} seconds for message {MessageId}. 的本地化字符串。
        /// </summary>
        internal static string ProcessTheMessageError {
            get {
                return ResourceManager.GetString("ProcessTheMessageError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Please configure the CalmFormatterLoadLogMessage formatter for this Listener. 的本地化字符串。
        /// </summary>
        internal static string RequiresCalmFormatterLoadLogMessage {
            get {
                return ResourceManager.GetString("RequiresCalmFormatterLoadLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Connection should be provided. 的本地化字符串。
        /// </summary>
        internal static string resources {
            get {
                return ResourceManager.GetString("resources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid message direction in stage SoapMessageStage.AfterDeSerialize 的本地化字符串。
        /// </summary>
        internal static string SoapExtensionMonitorInvalidAfterDeserializeDirection {
            get {
                return ResourceManager.GetString("SoapExtensionMonitorInvalidAfterDeserializeDirection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid message direction in stage SoapMessageStage.BeforeSerialize 的本地化字符串。
        /// </summary>
        internal static string SoapExtensionMonitorInvalidBeforeSserializeDirection {
            get {
                return ResourceManager.GetString("SoapExtensionMonitorInvalidBeforeSserializeDirection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid stage 的本地化字符串。
        /// </summary>
        internal static string SoapExtensionMonitorInvalidStage {
            get {
                return ResourceManager.GetString("SoapExtensionMonitorInvalidStage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ThreadPool.QueueUserWorkItem failed. 的本地化字符串。
        /// </summary>
        internal static string ThreadPoolQueueUserWorkItemFailed {
            get {
                return ResourceManager.GetString("ThreadPoolQueueUserWorkItemFailed", resourceCulture);
            }
        }
    }
}
