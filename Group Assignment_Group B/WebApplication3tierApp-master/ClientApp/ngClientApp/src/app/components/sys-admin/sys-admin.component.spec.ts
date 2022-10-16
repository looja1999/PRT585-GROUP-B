import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SysAdminComponent } from './sys-admin.component';

describe('SysAdminComponent', () => {
  let component: SysAdminComponent;
  let fixture: ComponentFixture<SysAdminComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SysAdminComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SysAdminComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
