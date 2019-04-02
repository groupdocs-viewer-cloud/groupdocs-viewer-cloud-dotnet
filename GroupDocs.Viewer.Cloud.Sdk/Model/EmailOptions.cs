// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="EmailOptions.cs">
//  Copyright (c) 2003-2019 Aspose Pty Ltd
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

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = GroupDocs.Viewer.Cloud.Sdk.Client.SwaggerDateConverter;

namespace GroupDocs.Viewer.Cloud.Sdk.Model
{
    /// <summary>
    /// Rendering options for Email file formats. Email file formats include files with extensions: .msg, .eml, .emlx, .ifc, .stl
    /// </summary>
    [DataContract]
    public partial class EmailOptions
    {
        /// <summary>
        /// The size of the output page when rendering as PDF or image. Supported values {Unknown|Letter|Ledger|A0|A1|A2|A3}: 1. Unknown - the default, unspecified page size. 2. Letter - the size of the Letter page in points is 792x612. 3. Ledger - the size of the Letter page in points is 1224x792. 4. A0 - the size of the A0 page in points is 3371x2384. 5. A1 - the size of the A1 page in points is 2384x1685. 6. A2 - the size of the A2 page in points is 1684x1190. 7. A3 - the size of the A3 page in points is 1190x842. 8. A4 - the size of the A4 page in points is 842x595.
        /// </summary>
        /// <value>The size of the output page when rendering as PDF or image. Supported values {Unknown|Letter|Ledger|A0|A1|A2|A3}: 1. Unknown - the default, unspecified page size. 2. Letter - the size of the Letter page in points is 792x612. 3. Ledger - the size of the Letter page in points is 1224x792. 4. A0 - the size of the A0 page in points is 3371x2384. 5. A1 - the size of the A1 page in points is 2384x1685. 6. A2 - the size of the A2 page in points is 1684x1190. 7. A3 - the size of the A3 page in points is 1190x842. 8. A4 - the size of the A4 page in points is 842x595.</value>
        [DataMember(Name="PageSize", EmitDefaultValue=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The list of supported email message field labels: 1. Field: \&quot;Anniversary\&quot; - default label is \&quot;Anniversary\&quot;. 2. Field: \&quot;Attachments\&quot; - default label is \&quot;Attachments\&quot;. 3. Field: \&quot;Bcc\&quot; - default label is \&quot;Bcc\&quot;. 4. Field: \&quot;Birthday\&quot; - default label is \&quot;Birthday\&quot;. 5. Field: \&quot;Business\&quot; - default label is \&quot;Business\&quot;. 6. Field: \&quot;BusinessAddress\&quot; - default label is \&quot;Business Address\&quot;. 7. Field: \&quot;BusinessFax\&quot; - default label is \&quot;Business Fax\&quot;. 8. Field: \&quot;BusinessHomepage\&quot; - default label is \&quot;BusinessHomePage\&quot;. 9. Field: \&quot;Cc\&quot; - default label is \&quot;Cc\&quot;. 10. Field: \&quot;Company\&quot; - default label is \&quot;Company\&quot;. 11. Field: \&quot;Department\&quot; - default label is \&quot;Department\&quot;. 12. Field: \&quot;Email\&quot; - default label is \&quot;Email\&quot;. 13. Field: \&quot;EmailDisplayAs\&quot; - default label is \&quot;Email Display As\&quot;. 14. Field: \&quot;Email2\&quot; - default label is \&quot;Email2\&quot;. 15. Field: \&quot;Email2DisplayAs\&quot; - default label is \&quot;Email2 Display As\&quot;. 16. Field: \&quot;Email3\&quot; - default label is \&quot;Email3\&quot;. 17. Field: \&quot;Email3DisplayAs\&quot; - default label is \&quot;Email3 Display As\&quot;. 18. Field: \&quot;End\&quot; - default label is \&quot;End\&quot;. 19. Field: \&quot;FirstName\&quot; - default label is \&quot;First Name\&quot;. 20. Field: \&quot;From\&quot; - default label is \&quot;From\&quot;. 21. Field: \&quot;FullName\&quot; - default label is \&quot;Full Name\&quot;. 22. Field: \&quot;Gender\&quot; - default label is \&quot;Gender\&quot;. 23. Field: \&quot;Hobbies\&quot; - default label is \&quot;Hobbies\&quot;. 24. Field: \&quot;Home\&quot; - default label is \&quot;Home\&quot;. 25. Field: \&quot;HomeAddress\&quot; - default label is \&quot;Home Address\&quot;. 26. Field: \&quot;Importance\&quot; - default label is \&quot;Importance\&quot;. 27. Field: \&quot;JobTitle\&quot; - default label is \&quot;Job Title\&quot;. 28. Field: \&quot;LastName\&quot; - default label is \&quot;Last Name\&quot;. 29. Field: \&quot;Location\&quot; - default label is \&quot;Location\&quot;. 30. Field: \&quot;MiddleName\&quot; - default label is \&quot;Middle Name\&quot;. 31. Field: \&quot;Mobile\&quot; - default label is \&quot;Mobile\&quot;. 32. Field: \&quot;Organizer\&quot; - default label is \&quot;Organizer\&quot;. 33. Field: \&quot;OtherAddress\&quot; - default label is \&quot;Other Address\&quot;. 34. Field: \&quot;PersonalHomepage\&quot; - default label is \&quot;PersonalHomePage\&quot;. 35. Field: \&quot;Profession\&quot; - default label is \&quot;Profession\&quot;. 36. Field: \&quot;Recurrence\&quot; - default label is \&quot;Recurrence\&quot;. 37. Field: \&quot;RecurrencePattern\&quot; - default label is \&quot;Recurrence Pattern\&quot;. 38. Field: \&quot;RequiredAttendees\&quot; - default label is \&quot;Required Attendees\&quot;. 39. Field: \&quot;Sent\&quot; - default label is \&quot;Sent\&quot;. 40. Field: \&quot;ShowTimeAs\&quot; - default label is \&quot;Show Time As\&quot;. 41. Field: \&quot;SpousePartner\&quot; - default label is \&quot;Spouse/Partner\&quot;. 42. Field: \&quot;Start\&quot; - default label is \&quot;Start\&quot;. 43. Field: \&quot;Subject\&quot; - default label is \&quot;Subject\&quot;. 44. Field: \&quot;To\&quot; - default label is \&quot;To\&quot;. 45. Field: \&quot;UserField1\&quot; - default label is \&quot;User Field 1\&quot;. 46. Field: \&quot;UserField2\&quot; - default label is \&quot;User Field 2\&quot;. 47. Field: \&quot;UserField3\&quot; - default label is \&quot;User Field 3\&quot;. 48. Field: \&quot;UserField4\&quot; - default label is \&quot;User Field 4\&quot;.
        /// </summary>
        /// <value>The list of supported email message field labels: 1. Field: \&quot;Anniversary\&quot; - default label is \&quot;Anniversary\&quot;. 2. Field: \&quot;Attachments\&quot; - default label is \&quot;Attachments\&quot;. 3. Field: \&quot;Bcc\&quot; - default label is \&quot;Bcc\&quot;. 4. Field: \&quot;Birthday\&quot; - default label is \&quot;Birthday\&quot;. 5. Field: \&quot;Business\&quot; - default label is \&quot;Business\&quot;. 6. Field: \&quot;BusinessAddress\&quot; - default label is \&quot;Business Address\&quot;. 7. Field: \&quot;BusinessFax\&quot; - default label is \&quot;Business Fax\&quot;. 8. Field: \&quot;BusinessHomepage\&quot; - default label is \&quot;BusinessHomePage\&quot;. 9. Field: \&quot;Cc\&quot; - default label is \&quot;Cc\&quot;. 10. Field: \&quot;Company\&quot; - default label is \&quot;Company\&quot;. 11. Field: \&quot;Department\&quot; - default label is \&quot;Department\&quot;. 12. Field: \&quot;Email\&quot; - default label is \&quot;Email\&quot;. 13. Field: \&quot;EmailDisplayAs\&quot; - default label is \&quot;Email Display As\&quot;. 14. Field: \&quot;Email2\&quot; - default label is \&quot;Email2\&quot;. 15. Field: \&quot;Email2DisplayAs\&quot; - default label is \&quot;Email2 Display As\&quot;. 16. Field: \&quot;Email3\&quot; - default label is \&quot;Email3\&quot;. 17. Field: \&quot;Email3DisplayAs\&quot; - default label is \&quot;Email3 Display As\&quot;. 18. Field: \&quot;End\&quot; - default label is \&quot;End\&quot;. 19. Field: \&quot;FirstName\&quot; - default label is \&quot;First Name\&quot;. 20. Field: \&quot;From\&quot; - default label is \&quot;From\&quot;. 21. Field: \&quot;FullName\&quot; - default label is \&quot;Full Name\&quot;. 22. Field: \&quot;Gender\&quot; - default label is \&quot;Gender\&quot;. 23. Field: \&quot;Hobbies\&quot; - default label is \&quot;Hobbies\&quot;. 24. Field: \&quot;Home\&quot; - default label is \&quot;Home\&quot;. 25. Field: \&quot;HomeAddress\&quot; - default label is \&quot;Home Address\&quot;. 26. Field: \&quot;Importance\&quot; - default label is \&quot;Importance\&quot;. 27. Field: \&quot;JobTitle\&quot; - default label is \&quot;Job Title\&quot;. 28. Field: \&quot;LastName\&quot; - default label is \&quot;Last Name\&quot;. 29. Field: \&quot;Location\&quot; - default label is \&quot;Location\&quot;. 30. Field: \&quot;MiddleName\&quot; - default label is \&quot;Middle Name\&quot;. 31. Field: \&quot;Mobile\&quot; - default label is \&quot;Mobile\&quot;. 32. Field: \&quot;Organizer\&quot; - default label is \&quot;Organizer\&quot;. 33. Field: \&quot;OtherAddress\&quot; - default label is \&quot;Other Address\&quot;. 34. Field: \&quot;PersonalHomepage\&quot; - default label is \&quot;PersonalHomePage\&quot;. 35. Field: \&quot;Profession\&quot; - default label is \&quot;Profession\&quot;. 36. Field: \&quot;Recurrence\&quot; - default label is \&quot;Recurrence\&quot;. 37. Field: \&quot;RecurrencePattern\&quot; - default label is \&quot;Recurrence Pattern\&quot;. 38. Field: \&quot;RequiredAttendees\&quot; - default label is \&quot;Required Attendees\&quot;. 39. Field: \&quot;Sent\&quot; - default label is \&quot;Sent\&quot;. 40. Field: \&quot;ShowTimeAs\&quot; - default label is \&quot;Show Time As\&quot;. 41. Field: \&quot;SpousePartner\&quot; - default label is \&quot;Spouse/Partner\&quot;. 42. Field: \&quot;Start\&quot; - default label is \&quot;Start\&quot;. 43. Field: \&quot;Subject\&quot; - default label is \&quot;Subject\&quot;. 44. Field: \&quot;To\&quot; - default label is \&quot;To\&quot;. 45. Field: \&quot;UserField1\&quot; - default label is \&quot;User Field 1\&quot;. 46. Field: \&quot;UserField2\&quot; - default label is \&quot;User Field 2\&quot;. 47. Field: \&quot;UserField3\&quot; - default label is \&quot;User Field 3\&quot;. 48. Field: \&quot;UserField4\&quot; - default label is \&quot;User Field 4\&quot;.</value>
        [DataMember(Name="FieldLabels", EmitDefaultValue=false)]
        public List<FieldLabel> FieldLabels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailOptions {\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  FieldLabels: ").Append(FieldLabels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
} 
