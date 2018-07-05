import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { OrderForm } from './components/OrderForm';
import { OrderPanel } from './components/OrderPanel';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';

export const routes = <Layout>
    <Route exact path='/' component={ Home } />
    <Route path='/orders/new' component={ OrderForm } />
    <Route path='/orders/list' component={ OrderPanel } />
    <Route path='/counter' component={ Counter } />
    <Route path='/fetchdata' component={ FetchData } />
</Layout>;

