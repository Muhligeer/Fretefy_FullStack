import { Component, OnInit } from '@angular/core';
import { Regiao } from 'src/app/interfaces/regiao';
import { RegioesService } from 'src/app/services/regioes.service';

@Component({
  selector: 'app-regiao',
  templateUrl: './regiao.component.html',
  styleUrls: ['./regiao.component.scss']
})
export class RegiaoComponent implements OnInit {

  regioes: Regiao[] = [];

  constructor(
    private regioesService: RegioesService
  ) { }

  ngOnInit() {
    this.regioesService.listarRegioes().subscribe({
      next: (regioes) => {
        console.log('Regiões recebidas:', regioes);
        this.regioes = regioes;
      },
      error: (error) => {
        console.error('Erro ao listar regiões:', error);
      }
    });
  }

}
