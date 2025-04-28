<template>
    <div class="container auth-container">
        <div class="auth-card">
            <div class="auth-header">
                <h2>Login</h2>
            </div>
            <div class="auth-body">
                <form @submit.prevent="login">
                    <div class="form-group">
                        <label for="username" class="form-label">Username</label>
                        <input type="text"
                               class="form-control"
                               id="username"
                               v-model="form.username"
                               placeholder="Enter your username"
                               required>
                    </div>
                    <div class="form-group">
                        <label for="password" class="form-label">Password</label>
                        <input type="password"
                               class="form-control"
                               id="password"
                               v-model="form.password"
                               placeholder="Enter your password"
                               required>
                    </div>
                    <button type="submit" class="btn custom-btn w-100">Login</button>
                </form>
            </div>
        </div>
    </div>
</template>

<script>
import { defineComponent, reactive } from 'vue';

export default defineComponent({
  name: 'LoginView',
  setup() {
    const form = reactive({
      username: '',
      password: ''
    });

    const login = () => {
      // Handle login form submission
      console.log('Login attempted with:', form);
      // You would typically authenticate with a backend service here
    };

    return {
      form,
      login
    };
  }
});
</script>

<style scoped>
    .auth-container {
        padding: 50px 15px;
        display: flex;
        justify-content: center;
    }

    .auth-card {
        width: 100%;
        max-width: 500px;
        border: 1px solid #e6e6e6;
        border-radius: 12px;
        overflow: hidden;
        box-shadow: 0 5px 15px rgba(0,0,0,0.1);
    }

    .auth-header {
        background-color: #f7f7f7;
        padding: 20px;
        text-align: center;
        border-bottom: 1px solid #e6e6e6;
    }

        .auth-header h2 {
            margin: 0;
            font-size: 24px;
            font-weight: 600;
        }

    .auth-body {
        padding: 25px;
    }

    .w-100 {
        width: 100%;
    }
</style>