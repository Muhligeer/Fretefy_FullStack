using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class RegiaoCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0a8248d1-3b62-4fb7-afc8-955b1c8ebc61"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0a8e109c-ee00-40d6-9a01-040618746f2f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("18e191f0-eef9-4451-bea1-de5f78d125f8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("439a8192-2f0f-43a7-8a2c-ee9bbbd6c4d3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("46698f17-4273-4e5c-a56d-dda97d426f26"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4b4077ab-47f7-44b6-bf44-56f03ca18532"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("588c12b7-703c-4944-b5ba-0fbed191eb02"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("596df90c-e617-45cb-be33-826801519e46"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("653fcdce-73b1-47ac-9e98-a5380bec8788"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6756d8f6-3f78-4886-91dd-e4753f9e72bc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6ab3cbd8-bcdf-4287-bee3-5885fb656d08"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("72b8cfd2-617d-435e-8f79-6e6e46aac155"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("784647e2-5430-459e-898b-4c915ee4b412"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7d73f17e-90d6-4230-a391-31520365ca67"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a3fc3b39-3c3c-4a58-8c50-fdd19209777f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a71ac957-1859-49b7-aa65-cc9327f4a3ce"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("afc12ff5-eacd-420a-835a-69e9b3b7821c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("bb824c5c-a427-4a95-a7b4-f8183f3f8e94"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c04bb270-65a7-4577-bd4c-631fa931d0e2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c215fc2e-bcda-4404-8efb-4b23c4433c5b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("dc5ff91b-68d1-4759-9dba-4ade4bd4740d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e3dcbced-4326-4007-94df-c33f8c77a204"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e7d03670-5d06-40dd-a4d8-41c4fe49a994"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ec209ffa-37ea-4587-8bc6-8afe7cd00042"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ec8390ca-f9a5-4a9e-9654-9405ccbabc7c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("eff2ddee-6df9-4d52-80b7-1e4b1164e343"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f8e6890f-e0d0-46ec-8f34-292de4b1f83b"));

            migrationBuilder.CreateTable(
                name: "Regiao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    Ativo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegiaoCidade",
                columns: table => new
                {
                    RegiaoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CidadeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegiaoCidade", x => new { x.RegiaoId, x.CidadeId });
                    table.ForeignKey(
                        name: "FK_RegiaoCidade_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegiaoCidade_Regiao_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "Regiao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d7be8d78-d2f7-41a1-a397-d8a6546862cb"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a511357e-0390-4902-ac4c-e76361a75074"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f38d983c-5763-487a-b769-1da9c78a64ce"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7502c5be-2a66-4a75-a661-8648279f9789"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("32abe71b-6cee-4ee3-8381-e1661df85142"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a56b0234-19bc-436f-ae6b-7dac3faa7078"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("793bc58d-8194-4f0d-91d3-9061d502f483"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("05f8ddd8-a041-41b9-a28e-97e8434ba4f3"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b07be96f-946a-48b2-a896-4cf949407807"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("3f988789-6d84-42f1-a3de-3062bb3a80a2"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("01fc4d06-d4f3-4f6c-b863-3a7f7fae5705"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("30b13f40-5831-4f92-9d6f-028cfaa5ec6a"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("97dd4ab7-8cbb-46df-acdd-e79672fb43fa"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("768268a0-580e-491d-a6bd-2660031417d6"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("82b3908c-7187-4815-90ad-6398458b31bf"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e31d286a-1617-4847-b896-95c88ff649c2"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0e04c589-b418-4668-b387-264d3c9f37b1"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("12cc2a7a-622f-4e41-86f7-ee5a840ead01"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0cbf7632-da33-43af-8a2a-42f1229ac78a"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("34540bb1-e894-4071-970c-c6a200d870f3"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1540c5fb-fc6c-4541-bda0-76e83245a330"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7c3e1417-2178-41e2-8d2a-4af8afd0213b"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("52ce6b9a-0f5e-44d0-abd6-ffa90e08ad3e"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("3d112a14-4d8f-40d8-91ed-f247763dc077"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f2a8346c-fce8-4559-957e-9ce8808f5d8c"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a6b439cb-f05d-4cd4-a51b-cd222011a0f1"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5d3550a4-865c-40c6-b6c8-f33a3ec2f78a"), "Palmas", "TO" });

            migrationBuilder.CreateIndex(
                name: "IX_RegiaoCidade_CidadeId",
                table: "RegiaoCidade",
                column: "CidadeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegiaoCidade");

            migrationBuilder.DropTable(
                name: "Regiao");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("01fc4d06-d4f3-4f6c-b863-3a7f7fae5705"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("05f8ddd8-a041-41b9-a28e-97e8434ba4f3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0cbf7632-da33-43af-8a2a-42f1229ac78a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0e04c589-b418-4668-b387-264d3c9f37b1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("12cc2a7a-622f-4e41-86f7-ee5a840ead01"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1540c5fb-fc6c-4541-bda0-76e83245a330"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("30b13f40-5831-4f92-9d6f-028cfaa5ec6a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("32abe71b-6cee-4ee3-8381-e1661df85142"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("34540bb1-e894-4071-970c-c6a200d870f3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3d112a14-4d8f-40d8-91ed-f247763dc077"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3f988789-6d84-42f1-a3de-3062bb3a80a2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("52ce6b9a-0f5e-44d0-abd6-ffa90e08ad3e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5d3550a4-865c-40c6-b6c8-f33a3ec2f78a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7502c5be-2a66-4a75-a661-8648279f9789"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("768268a0-580e-491d-a6bd-2660031417d6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("793bc58d-8194-4f0d-91d3-9061d502f483"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7c3e1417-2178-41e2-8d2a-4af8afd0213b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("82b3908c-7187-4815-90ad-6398458b31bf"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("97dd4ab7-8cbb-46df-acdd-e79672fb43fa"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a511357e-0390-4902-ac4c-e76361a75074"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a56b0234-19bc-436f-ae6b-7dac3faa7078"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a6b439cb-f05d-4cd4-a51b-cd222011a0f1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b07be96f-946a-48b2-a896-4cf949407807"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d7be8d78-d2f7-41a1-a397-d8a6546862cb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e31d286a-1617-4847-b896-95c88ff649c2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f2a8346c-fce8-4559-957e-9ce8808f5d8c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f38d983c-5763-487a-b769-1da9c78a64ce"));

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("afc12ff5-eacd-420a-835a-69e9b3b7821c"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c215fc2e-bcda-4404-8efb-4b23c4433c5b"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a71ac957-1859-49b7-aa65-cc9327f4a3ce"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c04bb270-65a7-4577-bd4c-631fa931d0e2"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0a8248d1-3b62-4fb7-afc8-955b1c8ebc61"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ec209ffa-37ea-4587-8bc6-8afe7cd00042"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f8e6890f-e0d0-46ec-8f34-292de4b1f83b"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6756d8f6-3f78-4886-91dd-e4753f9e72bc"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0a8e109c-ee00-40d6-9a01-040618746f2f"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("653fcdce-73b1-47ac-9e98-a5380bec8788"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("dc5ff91b-68d1-4759-9dba-4ade4bd4740d"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("eff2ddee-6df9-4d52-80b7-1e4b1164e343"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7d73f17e-90d6-4230-a391-31520365ca67"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e7d03670-5d06-40dd-a4d8-41c4fe49a994"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("72b8cfd2-617d-435e-8f79-6e6e46aac155"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("588c12b7-703c-4944-b5ba-0fbed191eb02"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("18e191f0-eef9-4451-bea1-de5f78d125f8"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bb824c5c-a427-4a95-a7b4-f8183f3f8e94"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("439a8192-2f0f-43a7-8a2c-ee9bbbd6c4d3"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("46698f17-4273-4e5c-a56d-dda97d426f26"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e3dcbced-4326-4007-94df-c33f8c77a204"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("784647e2-5430-459e-898b-4c915ee4b412"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("596df90c-e617-45cb-be33-826801519e46"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ec8390ca-f9a5-4a9e-9654-9405ccbabc7c"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a3fc3b39-3c3c-4a58-8c50-fdd19209777f"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4b4077ab-47f7-44b6-bf44-56f03ca18532"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6ab3cbd8-bcdf-4287-bee3-5885fb656d08"), "Palmas", "TO" });
        }
    }
}
