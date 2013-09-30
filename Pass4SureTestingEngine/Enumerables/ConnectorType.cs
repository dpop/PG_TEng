using System.ComponentModel;

namespace Pass4SureTestingEngine.Enumerables
{
    public enum ConnectorType
    {
        [Description("Undirected")]
        Undirected,

        [Description("Directed")]
        Directed,

        [Description("One To One")]
        OneToOne,

        [Description("One To Many")]
        OneToMany,

        [Description("Many To Many")]
        ManyToMany
    }
}
