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
    this.carregarRegioes();
  }

  private carregarRegioes() {
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

  alternarStatus(regiao: Regiao) {
    const novoStatus = { id: regiao.id, ativo: !regiao.ativo };
    this.regioesService.alterarStatus(regiao.id, novoStatus).subscribe({
      next: () => {
        regiao.ativo = novoStatus.ativo;
      },
      error: () => alert('Erro ao alterar status')
    });
  }
}
