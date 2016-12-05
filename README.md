### Experiment on top of original version
Added a multiple line interpreter for Android version: 
```cs```
 CrossLocalNotifications.Current.Show("Test", "This is a test notification"+ System.Environment.NewLine
                                                             + "that has multiple lines"+ System.Environment.NewLine
                                                             + "and so on ..." + System.Environment.NewLine
                                                             + "with a summary",2);
```
will create a InboxStyle notification in Android where the top min(N-1,5) lines will be added as inbox lines and the last (if exist) will be set as summary text. 

PS: also applied a PR fix for reopen issues (credit to @gadzair): original PR [here](https://github.com/edsnider/Xamarin.Plugins/pull/29).
