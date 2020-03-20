import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

export class DataService {
  constructor(
    protected httpClient: HttpClient,
    protected url: string,
    protected endpoint: string) { }

  public get<T>(route?: string): Observable<T> {

    const path = route == null ? `${this.endpoint}` : `${this.endpoint}/${route}`;
    return this.httpClient.get<T>(`${this.url}${path}`);
  }

  public post<T>(item: T, route?: string): Observable<T> {
    const path = route == null ? this.endpoint : `${this.endpoint}/${route}`;
    return this.httpClient
      .post<T>(`${this.url}${path}`, item);
  }

  public put<T>(item: T, route?: string): Observable<T> {
    const path = route == null ? this.endpoint : `${this.endpoint}/${route}`;
    return this.httpClient
      .put<T>(`${this.url}${path}`, item);
  }

  public delete(id: string, route?: string) {
    const path = route == null ? this.endpoint : `${this.endpoint}/${route}`;
    return this.httpClient
      .delete(`${this.url}${path}/${id}`);
  }

}
