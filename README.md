# WebhookSender
[![Hits](https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https%3A%2F%2Fgithub.com%2Fseungyup26%2Fwebhooksender&count_bg=%23FF0000&title_bg=%23555555&icon=&icon_color=%23E7E7E7&title=View&edge_flat=false)](https://hits.seeyoufarm.com)<br>
C# Discord Webhook Sender (very simple) <br>

```csharp
private static void SendWebHook(string hookURL, string name, string profile, string message)
{
        NameValueCollection webhookInfo = new NameValueCollection();
        webhookInfo.Add("username", name);
        webhookInfo.Add("avatar_url", profile);
        webhookInfo.Add("content", message);
        new WebClient().UploadValues(hookURL, webhookInfo);
}
```

# Setup
Visual Studio 2019 <br>
.NetFramework <br>
`$ git clone https://github.com/seungyup26/webhooksender`
