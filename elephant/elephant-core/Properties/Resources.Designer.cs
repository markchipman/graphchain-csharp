﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace elephant.core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("elephant.core.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE {?s ?p ?o}
        ///WHERE {?s ?p ?o}.
        /// </summary>
        public static string delete_all_triples {
            get {
                return ResourceManager.GetString("delete_all_triples", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONSTRUCT {{  &lt;{0}&gt; ?p ?o }}
        ///WHERE {{
        ///GRAPH &lt;{1}&gt;
        ///  {{
        ///    &lt;{0}&gt; ?p ?o
        ///  }} .
        ///}}.
        /// </summary>
        public static string get_block_header_by_iri {
            get {
                return ResourceManager.GetString("get_block_header_by_iri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CONSTRUCT {{  ?s ?p ?o }}
        ///WHERE {{
        ///GRAPH &lt;{0}&gt;
        ///  {{
        ///    ?s ?p ?o
        ///  }} .
        ///}}.
        /// </summary>
        public static string get_graph_by_iri {
            get {
                return ResourceManager.GetString("get_graph_by_iri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PREFIX bc: &lt;http://www.ontologies.makolab.com/bc/&gt;
        ///SELECT ?lastBlockIRI ?lastBlockHash ?lastBlockIndex
        ///WHERE
        ///{{
        ///  GRAPH &lt;{0}&gt;
        ///  {{
        ///    ?lastBlockIRI a bc:Block ;
        ///                  bc:hasHash ?lastBlockHash ;
        ///                  bc:hasIndex ?lastBlockIndex .
        ///    FILTER NOT EXISTS {{
        ///      ?prevBlockIRI bc:hasPreviousBlock ?lastBlockIRI .
        ///      FILTER ( ?prevBlockIRI != ?lastBlockIRI )
        ///    }}
        ///  }}
        ///}}.
        /// </summary>
        public static string get_last_block_info {
            get {
                return ResourceManager.GetString("get_last_block_info", resourceCulture);
            }
        }
    }
}
