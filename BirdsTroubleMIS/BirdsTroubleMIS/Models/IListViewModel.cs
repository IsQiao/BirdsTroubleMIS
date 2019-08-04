namespace BirdsTroubleMIS.Models
{
    interface IListViewModel<T>
    {
        int Total { get; set; }
        T List { get; set; }
    }
}
