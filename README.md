# Getting started

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (PagarmeAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=PagarmeAPI-CSharp&workspaceName=PagarmeAPI&projectName=PagarmeAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the PagarmeAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=PagarmeAPI-CSharp&workspaceName=PagarmeAPI&projectName=PagarmeAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=PagarmeAPI-CSharp&workspaceName=PagarmeAPI&projectName=PagarmeAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=PagarmeAPI-CSharp&workspaceName=PagarmeAPI&projectName=PagarmeAPI.Standard)

### 3. Add reference of the library project

In order to use the PagarmeAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=PagarmeAPI-CSharp&workspaceName=PagarmeAPI&projectName=PagarmeAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` PagarmeAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```PagarmeAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=PagarmeAPI-CSharp&workspaceName=PagarmeAPI&projectName=PagarmeAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=PagarmeAPI-CSharp&workspaceName=PagarmeAPI&projectName=PagarmeAPI.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| apiKey | TODO: add a description |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string apiKey = "apiKey";

PagarmeAPIClient client = new PagarmeAPIClient(apiKey);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [Transactions](#transactions)
* [Recipients](#recipients)
* [Withdrawals](#withdrawals)
* [Transfers](#transfers)

## <a name="transactions"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeAPI.Standard.Controllers.Transactions") Transactions

### Get singleton instance

The singleton instance of the ``` Transactions ``` class can be accessed from the API Client.

```csharp
Transactions transactions = client.Transactions;
```

### <a name="create_transaction"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Transactions.CreateTransaction") CreateTransaction

> TODO: Add a method description


```csharp
Task<Models.Transaction> CreateTransaction(Models.CreateTransaction request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.CreateTransaction();

Models.Transaction result = await transactions.CreateTransaction(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Validation error |


### <a name="capture_transaction"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Transactions.CaptureTransaction") CaptureTransaction

> TODO: Add a method description


```csharp
Task<Models.Transaction> CaptureTransaction(int id, Models.CaptureTransaction request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | TODO: Add a parameter description |
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int id = 150;
var request = new Models.CaptureTransaction();

Models.Transaction result = await transactions.CaptureTransaction(id, request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Validation error |


### <a name="refund_transaction"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Transactions.RefundTransaction") RefundTransaction

> TODO: Add a method description


```csharp
Task<Models.Transaction> RefundTransaction(int id, Models.RefundTransaction request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | TODO: Add a parameter description |
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
int id = 150;
var request = new Models.RefundTransaction();

Models.Transaction result = await transactions.RefundTransaction(id, request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Validation error |


### <a name="get_transaction_by_reference_key"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Transactions.GetTransactionByReferenceKey") GetTransactionByReferenceKey

> TODO: Add a method description


```csharp
Task<List<Models.Transaction>> GetTransactionByReferenceKey(string referenceKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| referenceKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string referenceKey = "reference_key";

List<Models.Transaction> result = await transactions.GetTransactionByReferenceKey(referenceKey);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="recipients"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeAPI.Standard.Controllers.Recipients") Recipients

### Get singleton instance

The singleton instance of the ``` Recipients ``` class can be accessed from the API Client.

```csharp
Recipients recipients = client.Recipients;
```

### <a name="create_recipient"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Recipients.CreateRecipient") CreateRecipient

> TODO: Add a method description


```csharp
Task<Models.Recipient> CreateRecipient(Models.CreateRecipient createRecipient)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| createRecipient |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var createRecipient = new Models.CreateRecipient();

Models.Recipient result = await recipients.CreateRecipient(createRecipient);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Validation error |


### <a name="get_recipient_by_id"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Recipients.GetRecipientById") GetRecipientById

> TODO: Add a method description


```csharp
Task<Models.Recipient> GetRecipientById(string recipientId, string apiKey)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | TODO: Add a parameter description |
| apiKey |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
string apiKey = "api_key";

Models.Recipient result = await recipients.GetRecipientById(recipientId, apiKey);

```


### <a name="update_recipient"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Recipients.UpdateRecipient") UpdateRecipient

> TODO: Add a method description


```csharp
Task<Models.Recipient> UpdateRecipient(string recipientId, Models.UpdateRecipient request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | TODO: Add a parameter description |
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";
var request = new Models.UpdateRecipient();

Models.Recipient result = await recipients.UpdateRecipient(recipientId, request);

```


### <a name="get_balance"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Recipients.GetBalance") GetBalance

> TODO: Add a method description


```csharp
Task<Models.GetBalance> GetBalance(string recipientId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recipientId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string recipientId = "recipient_id";

Models.GetBalance result = await recipients.GetBalance(recipientId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="withdrawals"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeAPI.Standard.Controllers.Withdrawals") Withdrawals

### Get singleton instance

The singleton instance of the ``` Withdrawals ``` class can be accessed from the API Client.

```csharp
Withdrawals withdrawals = client.Withdrawals;
```

### <a name="create_withdraw"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Withdrawals.CreateWithdraw") CreateWithdraw

> TODO: Add a method description


```csharp
Task<Models.Transfer> CreateWithdraw(Models.CreateWithdraw request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.CreateWithdraw();

Models.Transfer result = await withdrawals.CreateWithdraw(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Validation error |


### <a name="get_withdraw_by_id"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Withdrawals.GetWithdrawById") GetWithdrawById

> TODO: Add a method description


```csharp
Task<Models.Transfer> GetWithdrawById(string transferId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transferId |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string transferId = "transfer_id";

Models.Transfer result = await withdrawals.GetWithdrawById(transferId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="transfers"></a>![Class: ](https://apidocs.io/img/class.png "PagarmeAPI.Standard.Controllers.Transfers") Transfers

### Get singleton instance

The singleton instance of the ``` Transfers ``` class can be accessed from the API Client.

```csharp
Transfers transfers = client.Transfers;
```

### <a name="create_transfer"></a>![Method: ](https://apidocs.io/img/method.png "PagarmeAPI.Standard.Controllers.Transfers.CreateTransfer") CreateTransfer

> TODO: Add a method description


```csharp
Task<Models.Transfer> CreateTransfer(Models.CreateTransfer request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.CreateTransfer();

Models.Transfer result = await transfers.CreateTransfer(request);

```


[Back to List of Controllers](#list_of_controllers)



