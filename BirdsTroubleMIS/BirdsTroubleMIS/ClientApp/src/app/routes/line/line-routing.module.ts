import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LineCurdComponent } from './curd/curd.component';

const routes: Routes = [

  { path: 'curd', component: LineCurdComponent }];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LineRoutingModule { }
