import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Regiao } from "../interfaces/regiao";
import { environment } from "src/environments/environment";

@Injectable({
  providedIn: 'root'
})
export class RegioesService {
  constructor(private httpClient: HttpClient) { }

  listarRegioes() {
    return this.httpClient.get<Regiao[]>(environment.apiUrl + 'Regiao');
  }

  alterarStatus(id: string, ativo: { id: string, ativo: boolean }) {
    return this.httpClient.patch(`${environment.apiUrl}Regiao/${id}/status`, ativo);
  }

  criarRegiao(regiao: Regiao) {
    return this.httpClient.post<Regiao>(environment.apiUrl + 'Regiao', regiao);
  }

  atualizarRegiao(regiao: Regiao) {
    return this.httpClient.put<Regiao>(`${environment.apiUrl}Regiao/${regiao.id}`, regiao);
  }

  excluirRegiao(id: string) {
    return this.httpClient.delete(`${environment.apiUrl}Regiao/${id}`);
  }

  buscarRegiaoPorId(id: string) {
    return this.httpClient.get<Regiao>(`${environment.apiUrl}Regiao/${id}`);
  }
  
}