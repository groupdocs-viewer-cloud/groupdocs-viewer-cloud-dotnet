// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ProjectOptions.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
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
  /// The Microsoft Project documents rendering options.
  /// </summary>  
  public class ProjectOptions 
  {                       
        /// <summary>
        /// The size of the page. Supported values {Unknown|Letter|A0|A1|A2|A3}: 1. Unknown - the default, unspecified page size. 2. Letter - the size of the Letter page in points is 792 × 612. 3. Ledger - the size of the Letter page in points is 1224 × 792. 4. A0 - the size of the A0 page in points is 3371 × 2384. 5. A1 - the size of the A1 page in points is 2384 × 1685. 6. A2 - the size of the A2 page in points is 1684 × 1190. 7. A3 - the size of the A3 page in points is 1190 × 842. 8. A4 - the size of the A4 page in points is 842 × 595.
        /// </summary>  
        public string PageSize { get; set; }

        /// <summary>
        /// The time unit to use as minimal point. Supported values {Unknown|Days|ThirdsOfMonths|Months}: 1. Unknown - unknown, unspecified time scale. 2. Days - one day interval. 3. ThirdsOfMonths - one third of the month. 4. Months - one month interval.
        /// </summary>  
        public string TimeUnit { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class ProjectOptions {\n");
          sb.Append("  PageSize: ").Append(this.PageSize).Append("\n");
          sb.Append("  TimeUnit: ").Append(this.TimeUnit).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
