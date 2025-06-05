import { Cidade } from "./cidade";

export interface Regiao {
  id: number;
  nome: string;
  ativo: string;
  cidades: Cidade[];
}