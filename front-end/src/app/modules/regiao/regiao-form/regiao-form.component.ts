import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { RegioesService } from 'src/app/services/regioes.service';
import { Cidade } from 'src/app/interfaces/cidade';

@Component({
  selector: 'app-regiao-form',
  templateUrl: './regiao-form.component.html'
})
export class RegiaoFormComponent implements OnInit {
  form: FormGroup;
  cidades: Cidade[] = [];
  editando = false;
  id!: string;

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private regioesService: RegioesService,
    private http: HttpClient
  ) {
    this.form = this.fb.group({
      nome: [''],
      cidadesIds: [[]]
    });
  }

  ngOnInit(): void {
    this.http.get<Cidade[]>('https://localhost:5001/api/cidade')
      .subscribe(data => this.cidades = data);

    const idParam = this.route.snapshot.paramMap.get('id');
    if (idParam) {
      this.editando = true;
      this.id = idParam;
      this.regioesService.buscarRegiaoPorId(this.id).subscribe(regiao => {
        this.form.patchValue({
          nome: regiao.nome,
          cidadesIds: regiao.cidades.map(c => c.id)
        });
      });
    }
  }

  salvar() {
    const dto = this.form.value;
    const request = this.editando
      ? this.regioesService.atualizarRegiao(dto)
      : this.regioesService.criarRegiao(dto);

    request.subscribe({
      next: () => this.router.navigate(['/regioes']),
      error: () => alert('Erro ao salvar região')
    });
  }
}
