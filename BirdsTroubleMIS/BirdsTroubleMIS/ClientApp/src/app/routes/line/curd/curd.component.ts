import { Component, OnInit, ViewChild } from '@angular/core';
import { _HttpClient, ModalHelper } from '@delon/theme';
import { STColumn, STComponent } from '@delon/abc';
import { SFSchema } from '@delon/form';

@Component({
  selector: 'app-line-curd',
  templateUrl: './curd.component.html',
})
export class LineCurdComponent implements OnInit {
  url = `api/line`;
  searchSchema: SFSchema = {
    properties: {
      filterString: {
        type: 'string',
        title: '过滤字符串',
      },
    },
  };
  @ViewChild('st', { static: false }) st: STComponent;
  columns: STColumn[] = [
    { title: 'Id', index: 'id' },
    { title: '线路名称', /* type: 'string',*/ index: 'name' },
    {
      title: '操作',
      buttons: [
        // { text: '查看', click: (item: any) => `/form/${item.id}` },
        // { text: '编辑', type: 'static', component: FormEditComponent, click: 'reload' },
      ],
    },
  ];

  constructor(private http: _HttpClient, private modal: ModalHelper) {}

  ngOnInit() {}

  add() {
    // this.modal
    //   .createStatic(FormEditComponent, { i: { id: 0 } })
    //   .subscribe(() => this.st.reload());
  }
}
