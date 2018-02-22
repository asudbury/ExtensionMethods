<a name='contents'></a>
# Contents [#](#contents 'Go To Here')

- [DateTimeExtensions](#T-Scorchio-ExtensionMethods-DateTimeExtensions 'Scorchio.ExtensionMethods.DateTimeExtensions')
  - [IsTimeEqual(this,timeToCompare)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTimeEqual-System-DateTime,System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsTimeEqual(System.DateTime,System.DateTime)')
  - [IsToday(this)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsToday-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsToday(System.DateTime)')
  - [IsTomorrow(this)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTomorrow-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsTomorrow(System.DateTime)')
  - [IsWeekDay(this)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekDay-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsWeekDay(System.DateTime)')
  - [IsWeekendDay(this)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekendDay-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsWeekendDay(System.DateTime)')
  - [IsYesterday(this)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsYesterday-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.IsYesterday(System.DateTime)')
  - [StartOfYear(this)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-StartOfYear-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.StartOfYear(System.DateTime)')
  - [Tomorrow(this)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-Tomorrow-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.Tomorrow(System.DateTime)')
  - [Yesterday(this)](#M-Scorchio-ExtensionMethods-DateTimeExtensions-Yesterday-System-DateTime- 'Scorchio.ExtensionMethods.DateTimeExtensions.Yesterday(System.DateTime)')
- [MailMessageExtensions](#T-Scorchio-ExtensionMethods-MailMessageExtensions 'Scorchio.ExtensionMethods.MailMessageExtensions')
  - [Send(this)](#M-Scorchio-ExtensionMethods-MailMessageExtensions-Send-System-Net-Mail-MailMessage- 'Scorchio.ExtensionMethods.MailMessageExtensions.Send(System.Net.Mail.MailMessage)')
- [ObjectExtensions](#T-Scorchio-ExtensionMethods-ObjectExtensions 'Scorchio.ExtensionMethods.ObjectExtensions')
  - [SerializeToXml(this)](#M-Scorchio-ExtensionMethods-ObjectExtensions-SerializeToXml-System-Object- 'Scorchio.ExtensionMethods.ObjectExtensions.SerializeToXml(System.Object)')
- [StringExtensions](#T-Scorchio-ExtensionMethods-StringExtensions 'Scorchio.ExtensionMethods.StringExtensions')
  - [LowerCaseFirstCharacter(this)](#M-Scorchio-ExtensionMethods-StringExtensions-LowerCaseFirstCharacter-System-String- 'Scorchio.ExtensionMethods.StringExtensions.LowerCaseFirstCharacter(System.String)')
  - [Obfuscate(this,startPoint,length,character)](#M-Scorchio-ExtensionMethods-StringExtensions-Obfuscate-System-String,System-Int32,System-Int32,System-Char- 'Scorchio.ExtensionMethods.StringExtensions.Obfuscate(System.String,System.Int32,System.Int32,System.Char)')
  - [ToTitleCase(this)](#M-Scorchio-ExtensionMethods-StringExtensions-ToTitleCase-System-String- 'Scorchio.ExtensionMethods.StringExtensions.ToTitleCase(System.String)')
  - [UpperCaseFirstCharacter(this)](#M-Scorchio-ExtensionMethods-StringExtensions-UpperCaseFirstCharacter-System-String- 'Scorchio.ExtensionMethods.StringExtensions.UpperCaseFirstCharacter(System.String)')
- [XElementExtensions](#T-Scorchio-ExtensionMethods-XElementExtensions 'Scorchio.ExtensionMethods.XElementExtensions')
  - [GetAttributeValueOrDefault(this,attributeName,defaultValue)](#M-Scorchio-ExtensionMethods-XElementExtensions-GetAttributeValueOrDefault-System-Xml-Linq-XElement,System-String,System-String- 'Scorchio.ExtensionMethods.XElementExtensions.GetAttributeValueOrDefault(System.Xml.Linq.XElement,System.String,System.String)')
  - [GetElementValueOrDefault(this,elementName,defaultValue)](#M-Scorchio-ExtensionMethods-XElementExtensions-GetElementValueOrDefault-System-Xml-Linq-XElement,System-String,System-String- 'Scorchio.ExtensionMethods.XElementExtensions.GetElementValueOrDefault(System.Xml.Linq.XElement,System.String,System.String)')

<a name='assembly'></a>
# Scorchio.ExtensionMethods [#](#assembly 'Go To Here') [=](#contents 'Back To Contents')

<a name='T-Scorchio-ExtensionMethods-DateTimeExtensions'></a>
## DateTimeExtensions [#](#T-Scorchio-ExtensionMethods-DateTimeExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.ExtensionMethods

##### Summary

DateTime Extensions

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTimeEqual-System-DateTime,System-DateTime-'></a>
### IsTimeEqual(this,timeToCompare) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTimeEqual-System-DateTime,System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether [is time equal] [the specified time to compare].

##### Returns

`true` if [is time equal] [the specified time to compare]; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | This. |
| timeToCompare | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The time to compare. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsToday-System-DateTime-'></a>
### IsToday(this) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsToday-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether this instance is today.

##### Returns

`true` if the specified this is today; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | This. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTomorrow-System-DateTime-'></a>
### IsTomorrow(this) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsTomorrow-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether this instance is tomorrow.

##### Returns

`true` if the specified this is tomorrow; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | This. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekDay-System-DateTime-'></a>
### IsWeekDay(this) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekDay-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether [is week day].

##### Returns

`true` if [is week day] [the specified instance]; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | This. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekendDay-System-DateTime-'></a>
### IsWeekendDay(this) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsWeekendDay-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether [is weekend day].

##### Returns

`true` if [is weekend day] [the specified instance]; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | This. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-IsYesterday-System-DateTime-'></a>
### IsYesterday(this) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-IsYesterday-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Determines whether this instance is yesterday.

##### Returns

`true` if the specified this is yesterday; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | This. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-StartOfYear-System-DateTime-'></a>
### StartOfYear(this) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-StartOfYear-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Starts the of year.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | This. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-Tomorrow-System-DateTime-'></a>
### Tomorrow(this) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-Tomorrow-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Tomorrows the specified instance.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | This. |

<a name='M-Scorchio-ExtensionMethods-DateTimeExtensions-Yesterday-System-DateTime-'></a>
### Yesterday(this) `method` [#](#M-Scorchio-ExtensionMethods-DateTimeExtensions-Yesterday-System-DateTime- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Yesterdays the specified instance.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | This. |

<a name='T-Scorchio-ExtensionMethods-MailMessageExtensions'></a>
## MailMessageExtensions [#](#T-Scorchio-ExtensionMethods-MailMessageExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.ExtensionMethods

##### Summary

MailMessage Extensions.

<a name='M-Scorchio-ExtensionMethods-MailMessageExtensions-Send-System-Net-Mail-MailMessage-'></a>
### Send(this) `method` [#](#M-Scorchio-ExtensionMethods-MailMessageExtensions-Send-System-Net-Mail-MailMessage- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Sends the specified instance.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Net.Mail.MailMessage](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Mail.MailMessage 'System.Net.Mail.MailMessage') | The this. |

<a name='T-Scorchio-ExtensionMethods-ObjectExtensions'></a>
## ObjectExtensions [#](#T-Scorchio-ExtensionMethods-ObjectExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.ExtensionMethods

##### Summary

Object Extensions.

<a name='M-Scorchio-ExtensionMethods-ObjectExtensions-SerializeToXml-System-Object-'></a>
### SerializeToXml(this) `method` [#](#M-Scorchio-ExtensionMethods-ObjectExtensions-SerializeToXml-System-Object- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Serializes to Xml.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | This. |

<a name='T-Scorchio-ExtensionMethods-StringExtensions'></a>
## StringExtensions [#](#T-Scorchio-ExtensionMethods-StringExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.ExtensionMethods

##### Summary

String Extensions.

<a name='M-Scorchio-ExtensionMethods-StringExtensions-LowerCaseFirstCharacter-System-String-'></a>
### LowerCaseFirstCharacter(this) `method` [#](#M-Scorchio-ExtensionMethods-StringExtensions-LowerCaseFirstCharacter-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Lower cases the first character.

##### Returns

The string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This. |

<a name='M-Scorchio-ExtensionMethods-StringExtensions-Obfuscate-System-String,System-Int32,System-Int32,System-Char-'></a>
### Obfuscate(this,startPoint,length,character) `method` [#](#M-Scorchio-ExtensionMethods-StringExtensions-Obfuscate-System-String,System-Int32,System-Int32,System-Char- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Obfuscates the substring.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The this. |
| startPoint | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The start point. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |
| character | [System.Char](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Char 'System.Char') | The character. |

<a name='M-Scorchio-ExtensionMethods-StringExtensions-ToTitleCase-System-String-'></a>
### ToTitleCase(this) `method` [#](#M-Scorchio-ExtensionMethods-StringExtensions-ToTitleCase-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

To the title case.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This. |

<a name='M-Scorchio-ExtensionMethods-StringExtensions-UpperCaseFirstCharacter-System-String-'></a>
### UpperCaseFirstCharacter(this) `method` [#](#M-Scorchio-ExtensionMethods-StringExtensions-UpperCaseFirstCharacter-System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Uppercases the first character.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | This. |

<a name='T-Scorchio-ExtensionMethods-XElementExtensions'></a>
## XElementExtensions [#](#T-Scorchio-ExtensionMethods-XElementExtensions 'Go To Here') [=](#contents 'Back To Contents')

##### Namespace

Scorchio.ExtensionMethods

##### Summary

XElement Extensions

<a name='M-Scorchio-ExtensionMethods-XElementExtensions-GetAttributeValueOrDefault-System-Xml-Linq-XElement,System-String,System-String-'></a>
### GetAttributeValueOrDefault(this,attributeName,defaultValue) `method` [#](#M-Scorchio-ExtensionMethods-XElementExtensions-GetAttributeValueOrDefault-System-Xml-Linq-XElement,System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the attribute value or default.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | This. |
| attributeName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the attribute. |
| defaultValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The default value. |

<a name='M-Scorchio-ExtensionMethods-XElementExtensions-GetElementValueOrDefault-System-Xml-Linq-XElement,System-String,System-String-'></a>
### GetElementValueOrDefault(this,elementName,defaultValue) `method` [#](#M-Scorchio-ExtensionMethods-XElementExtensions-GetElementValueOrDefault-System-Xml-Linq-XElement,System-String,System-String- 'Go To Here') [=](#contents 'Back To Contents')

##### Summary

Gets the element value or default.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| this | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | This. |
| elementName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the element. |
| defaultValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The default value. |
