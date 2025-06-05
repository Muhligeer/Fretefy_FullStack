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

  alterarStatus(id: number, ativo: boolean) {
    return this.httpClient.patch(`${environment.apiUrl}Regiao/${id}/status=${ativo}`, {});
  }

  
}