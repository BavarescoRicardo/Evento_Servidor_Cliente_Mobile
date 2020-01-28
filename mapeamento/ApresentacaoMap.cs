    namespace Festival.mapeamento
{
    using FluentNHibernate.Mapping;

    class ApresentacaoMap : ClassMap<Festival.or.Apresentacao>
    {
        public ApresentacaoMap()
        {
            Id(c => c.id_apresentacao);
            Map(c => c.musica);
            Map(c => c.fk_cantor);
            Map(c => c.fk_categoria);

            Table("apresentacao");
        }
    }
}