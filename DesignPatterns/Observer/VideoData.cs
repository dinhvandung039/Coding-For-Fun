namespace Observer;

public class VideoData : Subject
{
    #region Private Properties
    private string _title;
    private string _description;
    private string _fileName;
    #endregion

    #region GetSetProperties
    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string value)
    {
        _title = value;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string value)
    {
        _description = value;
    }

    public string GetFileName()
    {
        return _fileName;
    }

    public void SetFileName(string value)
    {
        _fileName = value;
    }

    #endregion
    public void VideoDataChanged()
    {
        NotifyObservers(null);
    }
}
