Feature: Buy A Set Plan

Scenario Outline: Buying a SET Funeral Plan for New User
	Given I am on Home Page using <device> <browser> 
	#When I click Prepaid Funeral Plan <device>
	When I Select the Prepaid Funeral Plan <device> <browser>
	And Set Funeral plan as <BurialType> <PlanType> <NewUser>
	And creates New account and provide user details <Title> <FirstName > <LastName> <Gender> <BirthDate > <BirthMonth> <BirthYear> <device>
	And user provides Address Details <HouseNumber> <PostCode>
	And provides <PhoneNumber> <CoopMemNumber> <Password> <ConfirmPassword> 
	And user provides all payment Details <CardType> <paymenttype> <NameOnCard> <CardNumber> <ExpiryMonth> <ExpiryYear> <VisaDebitSecurityCode> <AccountName> <AccountNUmber> <SortCode1> <Sortcode2> <Sortcode3>
	#Then Order Confirmation Page is displayed along with the Plan Number

#@source:FMPTestData.xlsx:NewUser

Examples:
| browser | device              | BurialType    | PlanType | NewUser | Title | FirstName | LastName | Gender | BirthDate | BirthMonth | BirthYear | HouseNumber | PostCode | PhoneNumber | CoopMemNumber | Password   | ConfirmPassword    | CardType  | paymenttype | NameOnCard | CardNumber | ExpiryMonth | ExpiryYear       | VisaDebitSecurityCode | AccountName | AccountNUmber | SortCode1 | Sortcode2 | Sortcode3 |
#| Firefox | Laptop              | SetBurialPlan | Simple   | Yes     | Mr    | Holly1    | Cave     | Male   | 15011965  | NA         | 01        | 02          | 1965     | NA          | m43aq         | 0123456798 | 633174913070283000 | password1 | password1   | Visa Debit | OneOff     | Testing     | 4917480000000008 | May                   | 2021        | 202           | NA        | NA        | NA        |
#| Chrome  | Andriod_Phone       | SetBurialPlan | Simple   | Yes     | Mr    | Holly1    | Cave     | Male   | 15011965  | NA         | 01        | 02          | 1965     | NA          | m43aq         | 0123456798 | 633174913070283000 | password1 | password1   | Visa Debit | OneOff     | Testing     | 4917480000000008 | May                   | 2021        | 202           | NA        | NA        | NA        |
#| Chrome  | BrowserStack-Iphone | SetBurialPlan | Simple   | Yes     | Mr    | Holly1    | Cave     | Male   | 15011965  | NA         | 01        | 02          | 1965     | NA          | m43aq         | 0123456798 | 633174913070283000 | password1 | password1   | Visa Debit | OneOff     | Testing     | 4917480000000008 | May                   | 2021        | 202           | NA        | NA        | NA        |

Scenario Outline: Buying a SET Funeral Plan for an Existing user
	Given I am on Home Page using <device> <browser> 
	#When I click Prepaid Funeral Plan <device>
	When I Select the Prepaid Funeral Plan <device> <browser>
	And Set Funeral plan as <BurialType> <PlanType> <NewUser>
	And user logins using their <Email> <Password> <device>
	And user provides all payment Details <CardType> <paymenttype> <NameOnCard> <CardNumber> <ExpiryMonth> <ExpiryYear> <VisaDebitSecurityCode> <AccountName> <AccountNUmber> <SortCode1> <Sortcode2> <Sortcode3>
	Then Order Confirmation Page is displayed along with the Plan Number

##@source:FMPTestData.xlsx:ExistingUser

Examples:
| browser | device        | BurialType    | PlanType | NewUser | Email              | Password  | CardType   | paymenttype | NameOnCard | CardNumber       | ExpiryMonth | ExpiryYear | VisaDebitSecurityCode | AccountName | AccountNUmber | SortCode1 | Sortcode2 | Sortcode3 |
| Chrome  | Laptop        | SetBurialPlan | Simple   | No      | h1116604684@hs.com | password1 | Visa Debit | OneOff      | Testing    | 4917480000000008 | May         | 2021       | 202                   | NA          | NA            | Na        | NA        | NA        |
#| Chrome  | Andriod_Phone | SetBurialPlan | Simple   | No      | h1116604684@hs.com | password1 | Visa Debit | OneOff      | Testing    | 4917480000000008 | May         | 2021       | 202                   | NA          | NA            | Na        | NA        | NA        |



#	When I click Prepaid Funeral Plan
#	And Set Funeral Plan As <BurialType> <PlanType>
#	And creates New account and provide user details <Title> <FirstName > <LastName> <Gender> <BirthDate > <BirthMonth> <BirthYear> 
#	And user provides Address Details <HouseNumber> <PostCode>
#	And provides <PhoneNumber> <CoopMemNumber> <Password> <ConfirmPassword>
#	And user provides the Direct-Debit payment Details <AccountName> <AccountNumber> <SortCode1> <SortCode2> <SortCode3>
#	Then Order Confirmation Page is displayed along with the Plan Number
#
#@source:FMPTestData.xlsx:sheet2
#Examples: 
#| browser | BurialType    | PlanType | Title | FirstName | LastName | Gender | BirthDate | BirthMonth | BirthYear | HouseNumber | PostCode | PhoneNumber | CoopMemNumber      | Password  | ConfirmPassword | AccountName | AccountNumber | SortCode1 | SortCode2 | SortCode3 |

#Scenario Outline: Buying a SET Funeral Plan using Card
#	Given I am on the Home page using <browser>
#	When I click Prepaid Funeral Plan
#	And Set Funeral Plan As <BurialType> <PlanType>
#	And creates New account and provide user details <Title> <FirstName > <LastName> <Gender> <BirthDate > <BirthMonth> <BirthYear> 
#	And user provides Address Details <HouseNumber> <PostCode>
#	And provides <PhoneNumber> <CoopMemNumber> <Password> <ConfirmPassword>
#	And user provides the payment Details <CardType> <NameOnCard> <CardNumber> <ExpiryMonth> <ExpiryYear> <VisaDebitSecurityCode>
#	Then Order Confirmation Page is displayed along with the Plan Number
#
#Examples: 
#| browser | BurialType    | PlanType | Title | FirstName | LastName | Gender | BirthDate | BirthMonth | BirthYear | HouseNumber | PostCode | PhoneNumber | CoopMemNumber      | Password  | ConfirmPassword | CardType | NameOnCard | CardNumber       | ExpiryMonth | ExpiryYear | VisaDebitSecurityCode |
#| Chrome  | SetBurialPlan | Simple   | Mr    | Harry     | Potter   | Male   | 5         | January    | 1965      | A           | B        | 1234567     | 633174913070283079 | password1 | password1       | 2        | Testing    | 44137335600117780 | May         | 2017       | 222                   |