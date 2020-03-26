// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ProjectManagementOptions.cs">
//  Copyright (c) 2003-2020 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Viewer.Cloud.Sdk.Model 
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    
    /// <summary>
    /// Rendering options for Project file formats. Project file formats include files with extensions: .mpt, .mpp
    /// </summary>  
    public class ProjectManagementOptions 
    {                       
        /// <summary>
        /// The size of the page.
        /// </summary>
        /// <value>The size of the page.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PageSizeEnum
        { 
            /// <summary>
            /// Enum Unspecified for "Unspecified"
            /// </summary>            
            Unspecified,
            
            /// <summary>
            /// Enum Letter for "Letter"
            /// </summary>            
            Letter,
            
            /// <summary>
            /// Enum Ledger for "Ledger"
            /// </summary>            
            Ledger,
            
            /// <summary>
            /// Enum A0 for "A0"
            /// </summary>            
            A0,
            
            /// <summary>
            /// Enum A1 for "A1"
            /// </summary>            
            A1,
            
            /// <summary>
            /// Enum A2 for "A2"
            /// </summary>            
            A2,
            
            /// <summary>
            /// Enum A3 for "A3"
            /// </summary>            
            A3,
            
            /// <summary>
            /// Enum A4 for "A4"
            /// </summary>            
            A4            
        }

        /// <summary>
        /// The time unit to use as minimal point.
        /// </summary>
        /// <value>The time unit to use as minimal point.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeUnitEnum
        { 
            /// <summary>
            /// Enum Unspecified for "Unspecified"
            /// </summary>            
            Unspecified,
            
            /// <summary>
            /// Enum Days for "Days"
            /// </summary>            
            Days,
            
            /// <summary>
            /// Enum ThirdsOfMonths for "ThirdsOfMonths"
            /// </summary>            
            ThirdsOfMonths,
            
            /// <summary>
            /// Enum Months for "Months"
            /// </summary>            
            Months            
        }

        /// <summary>
        /// The size of the page.
        /// </summary>
        public PageSizeEnum? PageSize { get; set; }

        /// <summary>
        /// The time unit to use as minimal point.
        /// </summary>
        public TimeUnitEnum? TimeUnit { get; set; }

        /// <summary>
        /// The start date of a Gantt Chart View to render.        
        /// </summary>  
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date of a Gantt Chart View to render.
        /// </summary>  
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ProjectManagementOptions {\n");
          sb.Append("  PageSize: ").Append(this.PageSize).Append("\n");
          sb.Append("  TimeUnit: ").Append(this.TimeUnit).Append("\n");
          sb.Append("  StartDate: ").Append(this.StartDate).Append("\n");
          sb.Append("  EndDate: ").Append(this.EndDate).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
