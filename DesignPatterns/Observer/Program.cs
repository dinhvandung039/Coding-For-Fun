// observer allows some objects to notify other objects about changes in their state
// Complexity: 2
// Popularity: 3

using Observer;

var videoData = new VideoData();
_ = new EmailNotify(videoData);
var youtubeNotify = new YoutubeNotify(videoData);

videoData.SetTitle("Observer Design Pattern");
videoData.SetDescription("Observer Design Pattern");
videoData.SetFileName("Testing");
videoData.DetachObserver(youtubeNotify);
videoData.VideoDataChanged();
//_ = new FacebookNotifier(videoData);

Console.ReadKey();