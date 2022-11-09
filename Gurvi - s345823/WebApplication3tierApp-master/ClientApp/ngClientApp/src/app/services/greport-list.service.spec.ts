import { TestBed } from '@angular/core/testing';

import { GReportListService } from './greport-list.service';

describe('GReportListService', () => {
  let service: GReportListService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GReportListService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
