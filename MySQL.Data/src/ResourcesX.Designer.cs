﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySql.Data {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResourcesX {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourcesX() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MySql.Data.ResourcesX", typeof(ResourcesX).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Appdata path is not defined..
        /// </summary>
        internal static string AppdataNotDefined {
            get {
                return ResourceManager.GetString("AppdataNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication failed using MYSQL41 and SHA256_MEMORY. Check the user name and password or try using a secure connection..
        /// </summary>
        internal static string AuthenticationFailed {
            get {
                return ResourceManager.GetString("AuthenticationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You can&apos;t get more sessions because Client is closed..
        /// </summary>
        internal static string ClientIsClosed {
            get {
                return ResourceManager.GetString("ClientIsClosed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client option &apos;{0}&apos; does not support value &apos;{1}&apos;..
        /// </summary>
        internal static string ClientOptionInvalidValue {
            get {
                return ResourceManager.GetString("ClientOptionInvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client option &apos;{0}&apos; is not recognized as valid..
        /// </summary>
        internal static string ClientOptionNotValid {
            get {
                return ResourceManager.GetString("ClientOptionNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} &apos;{1}&apos; does not exist in schema &apos;{2}&apos;..
        /// </summary>
        internal static string CollectionTableDoesNotExist {
            get {
                return ResourceManager.GetString("CollectionTableDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compression requested but the compression algorithm negotiation failed..
        /// </summary>
        internal static string CompressionAlgorithmNegotiationFailed {
            get {
                return ResourceManager.GetString("CompressionAlgorithmNegotiationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compression using {0} is not supported..
        /// </summary>
        internal static string CompressionAlgorithmNotSupported {
            get {
                return ResourceManager.GetString("CompressionAlgorithmNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load libzstd.dll. Removing zstd_stream from the client supported compression algorithms..
        /// </summary>
        internal static string CompressionFailedToLoadLibzstdAssembly {
            get {
                return ResourceManager.GetString("CompressionFailedToLoadLibzstdAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compression using {0} is not supported in .NET Framework..
        /// </summary>
        internal static string CompressionForSpecificAlgorithmNotSupportedInNetFramework {
            get {
                return ResourceManager.GetString("CompressionForSpecificAlgorithmNotSupportedInNetFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection property &apos;compression&apos; acceptable values are: &apos;preferred&apos;, &apos;required&apos; or &apos;disabled&apos;. The value &apos;{0}&apos; is not acceptable..
        /// </summary>
        internal static string CompressionInvalidValue {
            get {
                return ResourceManager.GetString("CompressionInvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compression is not enabled..
        /// </summary>
        internal static string CompressionNotEnabled {
            get {
                return ResourceManager.GetString("CompressionNotEnabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Compression requested but the server does not support it..
        /// </summary>
        internal static string CompressionNotSupportedByServer {
            get {
                return ResourceManager.GetString("CompressionNotSupportedByServer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are still decompressed messages pending to be processed..
        /// </summary>
        internal static string CompressionPendingMessagesToProcess {
            get {
                return ResourceManager.GetString("CompressionPendingMessagesToProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; cannot be set to false with DNS SRV lookup enabled..
        /// </summary>
        internal static string DnsSrvConflictingOptions {
            get {
                return ResourceManager.GetString("DnsSrvConflictingOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheme &apos;{0}&apos; is not valid..
        /// </summary>
        internal static string DnsSrvInvalidScheme {
            get {
                return ResourceManager.GetString("DnsSrvInvalidScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The document path cannot be null or an empty string..
        /// </summary>
        internal static string DocPathNullOrEmpty {
            get {
                return ResourceManager.GetString("DocPathNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate key &apos;{0}&apos; used in &quot;connection-attributes&quot;..
        /// </summary>
        internal static string DuplicateUserDefinedAttribute {
            get {
                return ResourceManager.GetString("DuplicateUserDefinedAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key name in connection attribute cannot be an empty string..
        /// </summary>
        internal static string EmptyKeyConnectionAttribute {
            get {
                return ResourceManager.GetString("EmptyKeyConnectionAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one option must be specified..
        /// </summary>
        internal static string EmptyOptions {
            get {
                return ResourceManager.GetString("EmptyOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This feature is currently not supported..
        /// </summary>
        internal static string FeatureNotSupported {
            get {
                return ResourceManager.GetString("FeatureNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This functionality is only supported in MySQL {0} and higher..
        /// </summary>
        internal static string FunctionalityNotSupported {
            get {
                return ResourceManager.GetString("FunctionalityNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Collation with id &apos;{0}&apos; not found..
        /// </summary>
        internal static string InvalidCollationId {
            get {
                return ResourceManager.GetString("InvalidCollationId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of &quot;connection-attributes&quot; must be either a boolean or a list of key-value pairs..
        /// </summary>
        internal static string InvalidConnectionAttributes {
            get {
                return ResourceManager.GetString("InvalidConnectionAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection Data is incorrect..
        /// </summary>
        internal static string InvalidConnectionData {
            get {
                return ResourceManager.GetString("InvalidConnectionData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection string is invalid..
        /// </summary>
        internal static string InvalidConnectionString {
            get {
                return ResourceManager.GetString("InvalidConnectionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid connection string attribute..
        /// </summary>
        internal static string InvalidConnectionStringAttribute {
            get {
                return ResourceManager.GetString("InvalidConnectionStringAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The connection timeout value must be a positive integer (including 0)..
        /// </summary>
        internal static string InvalidConnectionTimeoutValue {
            get {
                return ResourceManager.GetString("InvalidConnectionTimeoutValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Decimal (BCD) format is invalid..
        /// </summary>
        internal static string InvalidDecimalFormat {
            get {
                return ResourceManager.GetString("InvalidDecimalFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field type with name &apos;{0}&apos; not found..
        /// </summary>
        internal static string InvalidFieldType {
            get {
                return ResourceManager.GetString("InvalidFieldType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Index type with name &apos;{0}&apos; not found..
        /// </summary>
        internal static string InvalidIndexType {
            get {
                return ResourceManager.GetString("InvalidIndexType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value provided is not a valid JSON document. {0}.
        /// </summary>
        internal static string InvalidJsonDocument {
            get {
                return ResourceManager.GetString("InvalidJsonDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid column name in the row..
        /// </summary>
        internal static string InvalidNameIndex {
            get {
                return ResourceManager.GetString("InvalidNameIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid index for the row..
        /// </summary>
        internal static string InvalidRowIndex {
            get {
                return ResourceManager.GetString("InvalidRowIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session state is not valid..
        /// </summary>
        internal static string InvalidSession {
            get {
                return ResourceManager.GetString("InvalidSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Uri .
        /// </summary>
        internal static string InvalidUriData {
            get {
                return ResourceManager.GetString("InvalidUriData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid uri query value.
        /// </summary>
        internal static string InvalidUriQuery {
            get {
                return ResourceManager.GetString("InvalidUriQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Key names in &quot;connection-attributes&quot; cannot start with &quot;_&quot;..
        /// </summary>
        internal static string InvalidUserDefinedAttribute {
            get {
                return ResourceManager.GetString("InvalidUserDefinedAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Json configuration must contain &apos;uri&apos; or &apos;host&apos; but not both..
        /// </summary>
        internal static string JsonUriOrHost {
            get {
                return ResourceManager.GetString("JsonUriOrHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keyword &apos;{0}&apos; not found..
        /// </summary>
        internal static string KeywordNotFound {
            get {
                return ResourceManager.GetString("KeywordNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Keyword not supported..
        /// </summary>
        internal static string KeywordNotSupported {
            get {
                return ResourceManager.GetString("KeywordNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field &apos;{0}&apos; is mandatory..
        /// </summary>
        internal static string MandatoryFieldNotFound {
            get {
                return ResourceManager.GetString("MandatoryFieldNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missed required schema option..
        /// </summary>
        internal static string MissingSchemaOption {
            get {
                return ResourceManager.GetString("MissingSchemaOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one document id was generated.  Please use the DocumentIds property instead..
        /// </summary>
        internal static string MoreThanOneDocumentId {
            get {
                return ResourceManager.GetString("MoreThanOneDocumentId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no data at index {0}.
        /// </summary>
        internal static string NoDataAtIndex {
            get {
                return ResourceManager.GetString("NoDataAtIndex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No &apos;host&apos; has been specified..
        /// </summary>
        internal static string NoHost {
            get {
                return ResourceManager.GetString("NoHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No more data in resultset..
        /// </summary>
        internal static string NoMoreData {
            get {
                return ResourceManager.GetString("NoMoreData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object &apos;{0}&apos; not found.
        /// </summary>
        internal static string NoObjectFound {
            get {
                return ResourceManager.GetString("NoObjectFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No placeholders..
        /// </summary>
        internal static string NoPlaceholders {
            get {
                return ResourceManager.GetString("NoPlaceholders", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection closed. Reason: connection idle was too long.
        /// </summary>
        internal static string NoticeIdleConnection {
            get {
                return ResourceManager.GetString("NoticeIdleConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection closed. Reason: connection was killed by a different session.
        /// </summary>
        internal static string NoticeKilledConnection {
            get {
                return ResourceManager.GetString("NoticeKilledConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection closed. Reason: server was shutdown.
        /// </summary>
        internal static string NoticeServerShutdown {
            get {
                return ResourceManager.GetString("NoticeServerShutdown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be a value greater than 0..
        /// </summary>
        internal static string NumberNotGreaterThanZero {
            get {
                return ResourceManager.GetString("NumberNotGreaterThanZero", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Path not found &apos;{0}&apos;..
        /// </summary>
        internal static string PathNotFound {
            get {
                return ResourceManager.GetString("PathNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Queue timeout expired. The timeout period elapsed prior to getting a session from the pool..
        /// </summary>
        internal static string PoolingQueueTimeout {
            get {
                return ResourceManager.GetString("PoolingQueueTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Providing a port number as part of the host address isn&apos;t supported when using connection strings in basic format or anonymous objects. Use URI format instead..
        /// </summary>
        internal static string PortNotSupported {
            get {
                return ResourceManager.GetString("PortNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must either assign no priority to any of the hosts or give a priority for every host..
        /// </summary>
        internal static string PriorityForAllOrNoHosts {
            get {
                return ResourceManager.GetString("PriorityForAllOrNoHosts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The priority must be between 0 and 100..
        /// </summary>
        internal static string PriorityOutOfLimits {
            get {
                return ResourceManager.GetString("PriorityOutOfLimits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ProgramData path is not defined..
        /// </summary>
        internal static string ProgramDataNotDefined {
            get {
                return ResourceManager.GetString("ProgramDataNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replacement document has an &apos;_id&apos; that is
        ///different from the matched document..
        /// </summary>
        internal static string ReplaceWithNoMatchingId {
            get {
                return ResourceManager.GetString("ReplaceWithNoMatchingId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The server doesn&apos;t support the requested operation. Please update the MySQL Server, client library, or both..
        /// </summary>
        internal static string SchemaCreateCollectionMsg {
            get {
                return ResourceManager.GetString("SchemaCreateCollectionMsg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The process of closing the resultset and resulted in results being lost..
        /// </summary>
        internal static string ThrowingAwayResults {
            get {
                return ResourceManager.GetString("ThrowingAwayResults", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All server connection attempts were aborted. Timeout of {0} milliseconds was exceeded for each selected server..
        /// </summary>
        internal static string TimeOutMultipleHost {
            get {
                return ResourceManager.GetString("TimeOutMultipleHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All server connection attempts were aborted. Timeout was exceeded for each selected server..
        /// </summary>
        internal static string TimeOutMultipleHost0ms {
            get {
                return ResourceManager.GetString("TimeOutMultipleHost0ms", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection attempt to the server was aborted. Timeout of {0} milliseconds was exceeded..
        /// </summary>
        internal static string TimeOutSingleHost {
            get {
                return ResourceManager.GetString("TimeOutSingleHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection attempt to the server was aborted. Timeout was exceeded..
        /// </summary>
        internal static string TimeOutSingleHost0ms {
            get {
                return ResourceManager.GetString("TimeOutSingleHost0ms", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to connect to any specified host..
        /// </summary>
        internal static string UnableToConnect {
            get {
                return ResourceManager.GetString("UnableToConnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to read or decode data value..
        /// </summary>
        internal static string UnableToDecodeDataValue {
            get {
                return ResourceManager.GetString("UnableToDecodeDataValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to open a session..
        /// </summary>
        internal static string UnableToOpenSession {
            get {
                return ResourceManager.GetString("UnableToOpenSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected end of packet found while reading data values.
        /// </summary>
        internal static string UnexpectedEndOfPacketFound {
            get {
                return ResourceManager.GetString("UnexpectedEndOfPacketFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field name &apos;{0}&apos; is not allowed..
        /// </summary>
        internal static string UnexpectedField {
            get {
                return ResourceManager.GetString("UnexpectedField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown placeholder :{0}.
        /// </summary>
        internal static string UnknownPlaceholder {
            get {
                return ResourceManager.GetString("UnknownPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value &apos;{0}&apos; is not of the correct type..
        /// </summary>
        internal static string ValueNotCorrectType {
            get {
                return ResourceManager.GetString("ValueNotCorrectType", resourceCulture);
            }
        }
    }
}
