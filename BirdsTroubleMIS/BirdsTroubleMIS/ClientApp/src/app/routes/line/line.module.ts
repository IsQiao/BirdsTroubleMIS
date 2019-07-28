import { NgModule } from '@angular/core';
import { SharedModule } from '@shared';
import { LineRoutingModule } from './line-routing.module';
import { LineCurdComponent } from './curd/curd.component';

const COMPONENTS = [
  LineCurdComponent];
const COMPONENTS_NOROUNT = [];

@NgModule({
  imports: [
    SharedModule,
    LineRoutingModule
  ],
  declarations: [
    ...COMPONENTS,
    ...COMPONENTS_NOROUNT
  ],
  entryComponents: COMPONENTS_NOROUNT
})
export class LineModule { }
