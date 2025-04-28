import { createApp } from 'vue'
import { createRouter, createWebHistory } from 'vue-router'
import App from './App.vue'
import './style.css'

const routes = [
    {
        path: '/',
        name: 'home',
        component: () => import('./components/HomeView.vue')
    },
    {
        path: '/listings',
        name: 'listings',
        component: () => import('./components/ListingsView.vue')
    },
    {
        path: '/details',
        name: 'details',
        component: () => import('./components/DetailsView.vue')
    },
    {
        path: '/about',
        name: 'about',
        component: () => import('./components/AboutView.vue')
    },
    {
        path: '/contact',
        name: 'contact',
        component: () => import('./components/ContactView.vue')
    },
    {
        path: '/login',
        name: 'login',
        component: () => import('./components/LoginView.vue')
    },
    {
        path: '/register',
        name: 'register',
        component: () => import('./components/RegisterView.vue')
    },
    {
        path: '/privacy',
        name: 'privacy',
        component: () => import('./components/PrivacyView.vue')
    }
]

const router = createRouter({
    history: createWebHistory(),
    routes
})

const app = createApp(App)
app.use(router)
app.mount('#app')