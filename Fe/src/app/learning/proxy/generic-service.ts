import { HttpClient } from "@angular/common/http";
import { Environment } from "environment";
import { Observable } from "rxjs";

export class IGenericService<T> {
    apiUrl: string = Environment.apiUrl;
    constructor(private httpClient: HttpClient) 
    {
    }

    getAll(): Observable<T[]> {
        return this.httpClient.get<T[]>(this.apiUrl);
    }
    get(id: number): Observable<T> {
        return this.httpClient.get<T>(`${this.apiUrl}/${id}`);
    }
    post(item: T): Observable<T> {
        return this.httpClient.post<T>(`${this.apiUrl}/post`, item);
    }
    put(id: number, item: T): Observable<T> {
        return this.httpClient.put<T>(`${this.apiUrl}/put`, item);
    }
    delete(id: number): Observable<void> {
        return this.httpClient.delete<void>(`${this.apiUrl}/delete`);
    }
}