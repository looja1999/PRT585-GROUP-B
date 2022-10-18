import { TestBed } from '@angular/core/testing';

import { ReportListService } from './report-list.service';

describe('ReportListService', () => {
  let service: ReportListService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ReportListService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
