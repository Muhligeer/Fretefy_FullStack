import { RouterModule, Routes } from '@angular/router';
import { RegiaoComponent } from './regiao.component';
import { RegiaoFormComponent } from './regiao-form/regiao-form.component';

const routes: Routes = [
  { 
    path: '',
    component: RegiaoComponent
  },
  { 
    path: 'new', 
    component: RegiaoFormComponent 
  },
  { 
    path: 'edit/:id', 
    component: RegiaoFormComponent 
  }
];

export const  RegiaoRoutingModule = RouterModule.forChild(routes);